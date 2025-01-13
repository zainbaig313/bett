using System;
using System.Windows.Forms;

namespace bett
{
    public partial class Football : Form
    {
        private string resultVideo = "Miss"; // Default result for the video
        private string defaultVideoPath = "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\miss7.mp4";
        private double stoppedAt = 0; // Variable to store the stopping position

        public Football()
        {
            InitializeComponent();
        }

        private void Football_Load(object sender, EventArgs e)
        {
            // Display the current coin balance
            labelCoinsFootball.Text = $"{GameManager.Coins}";

            // Play the default video on form load
            wmpFootball.URL = defaultVideoPath;
            wmpFootball.Ctlcontrols.play();

            // Start the timer to monitor playback and stop at 10 seconds
            footballTimer.Interval = 100; // Timer ticks every 100ms for better precision
            footballTimer.Enabled = true;
        }

        private void footballTimer_Tick(object sender, EventArgs e)
        {
            // Check the current position of the video
            if (wmpFootball.Ctlcontrols.currentPosition >= 10)
            {
                stoppedAt = wmpFootball.Ctlcontrols.currentPosition; // Save the stopping position
                wmpFootball.Ctlcontrols.pause(); // Pause the video at 10 seconds
                footballTimer.Enabled = false; // Disable the timer
                MessageBox.Show("Select your betting amount and choose Goal or Miss!");
            }
        }

        private void btnPlayFootball_Click(object sender, EventArgs e)
        {
            // Validate the user's input
            if (CbBettingAmountFootball.SelectedItem == null)
            {
                MessageBox.Show("Please select a betting amount.");
                return;
            }

            if (!radioButtonGoal.Checked && !radioButtonMiss.Checked)
            {
                MessageBox.Show("Please select Goal or Miss.");
                return;
            }

            // Resume video playback from where it stopped
            wmpFootball.Ctlcontrols.currentPosition = stoppedAt; // Set the video to start from the stopping position
            wmpFootball.Ctlcontrols.play();

            // Register an event for when the video stops playing
            wmpFootball.PlayStateChange += WmpFootball_PlayStateChange;
        }

        private void WmpFootball_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Check if the video has stopped playing
            if (e.newState == 8) // 8 = Stopped
            {
                string userChoice = radioButtonGoal.Checked ? "Goal" : "Miss";
                int bettingAmount = int.Parse(CbBettingAmountFootball.SelectedItem.ToString());

                // Compare the user's choice with the actual result
                if (userChoice == resultVideo)
                {
                    int winnings = (int)(bettingAmount * 0.7);
                    GameManager.Coins += winnings;
                    result.Text = $"You are correct! It was {resultVideo}. Coins increased by {winnings}.";
                }
                else
                {
                    GameManager.Coins -= bettingAmount;
                    result.Text = $"You are wrong! It was {resultVideo}. Coins decreased by {bettingAmount}.";
                }

                // Update the coins display
                labelCoinsFootball.Text = GameManager.Coins.ToString();
            }
        }
    }
}
