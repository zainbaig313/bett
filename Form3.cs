using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bett
{
    public partial class Form3 : Form
    {
        private string resultVideo; // To store the result type ("Six", "Four", "Out")
        private List<string> allVideos = new List<string>
        {
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\out1.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\out2.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\out3.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\four1.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\four2.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\four3.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\six1.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\six2.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\six3.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\circketVideos\\six4.mp4"
        };

        private List<string> playedVideos = new List<string>(); // To track played videos
        private Random random = new Random(); // For random selection
        private double stoppedAt = 0; // Variable to store the stopping position

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            wmpForm3.uiMode = "none";
            radioButtonSix.Checked = false;
            radioButtonFour.Checked = false;
            radioButtonOut.Checked = false;
            labelCoinsForm3.Text = $"{GameManager.Coins}";
        }

        private void cricketTimer_Tick(object sender, EventArgs e)
        {
            if (wmpForm3.Ctlcontrols.currentPosition >= 5) // Check if the current position has reached 5 seconds
            {
                stoppedAt = wmpForm3.Ctlcontrols.currentPosition;
                wmpForm3.Ctlcontrols.pause();  // Stop the video at 5 seconds
                cricketTimer.Enabled = false;  // Stop the timer
                MessageBox.Show("Select your betting amount and choose Six, Four, or Out!");  // Show the selection prompt
            }
        }

        private void btnPlayForm3_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if user has enough coins
                if (GameManager.Coins == 0)
                {
                    MessageBox.Show("You have 0 coins. You cannot place a bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure the user selected a betting amount
                if (CbBettingAmountForm3.SelectedItem == null)
                {
                    MessageBox.Show("Please select a betting amount.");
                    return;
                }

                // Ensure the user selected Six, Four, or Out
                if (!radioButtonSix.Checked && !radioButtonFour.Checked && !radioButtonOut.Checked)
                {
                    MessageBox.Show("Please select Six, Four, or Out.");
                    return;
                }

                int bettingAmount = int.Parse(CbBettingAmountForm3.SelectedItem.ToString());

                // Check if user has enough coins for the selected bet
                if (bettingAmount > GameManager.Coins)
                {
                    MessageBox.Show("You do not have enough coins to place this bet.", "Insufficient Coins", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                wmpForm3.Ctlcontrols.currentPosition = stoppedAt;  // Resume video playback from the stopped position
                wmpForm3.Ctlcontrols.play();  // Play the video from the 5-second point
                wmpForm3.PlayStateChange += WmpForm3_PlayStateChange;  // Handle the play state change
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }



        private void WmpForm3_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            try
            {
                if (e.newState == 8) // 8 = Stopped
                {
                    // Check if the betting amount is selected before proceeding
                    if (CbBettingAmountForm3.SelectedItem == null)
                    {
                        CbBettingAmountForm3.BackColor = Color.White;
                        return; // Exit the method early if no betting amount is selected
                    }

                    string userChoice = radioButtonSix.Checked ? "Six" : radioButtonFour.Checked ? "Four" : "Out";
                    int bettingAmount = int.Parse(CbBettingAmountForm3.SelectedItem.ToString());

                    // Check if the user's choice matches the result
                    if (userChoice == resultVideo)
                    {
                        int winnings = (int)(bettingAmount * 0.7);
                        GameManager.Coins += winnings;
                        resultForm3.Text = $"You are correct! It was {resultVideo}. Coins increased by {winnings}.";
                    }
                    else
                    {
                        GameManager.Coins -= bettingAmount;

                        // Check if coins go below 0
                        if (GameManager.Coins < 0)
                        {
                            throw new InvalidOperationException("Insufficient coins. You cannot continue betting.");
                        }

                        resultForm3.Text = $"You are wrong! It was {resultVideo}. Coins decreased by {bettingAmount}.";
                    }

                    labelCoinsForm3.Text = GameManager.Coins.ToString();

                    // Reset betting controls after the video ends
                    CbBettingAmountForm3.SelectedIndex = -1;  // Use SelectedIndex to clear selection
                    radioButtonSix.Checked = false;
                    radioButtonFour.Checked = false;
                    radioButtonOut.Checked = false;
                }
            }
            catch (FormatException ex)
            {
                // Handle invalid format for betting amount
                MessageBox.Show("Invalid betting amount format. Please select a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                // Handle coins going below zero
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Reset coins to 0
                GameManager.Coins = 0;
                labelCoinsForm3.Text = GameManager.Coins.ToString();
            }
            catch (Exception ex)
            {
                // Handle unforeseen errors
                MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }



        private void btnStartForm3_Click(object sender, EventArgs e)
        {
            // Check if the user has 0 coins
            if (GameManager.Coins == 0)
            {
                MessageBox.Show("You have 0 coins. You cannot start the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (playedVideos.Count == allVideos.Count) // Check if all videos have been played
            {
                MessageBox.Show("We are out of videos. Please come back later!");
                return;
            }

            string selectedVideo;
            do
            {
                selectedVideo = allVideos[random.Next(allVideos.Count)];
            } while (playedVideos.Contains(selectedVideo));  // Ensure the selected video hasn't been played before

            playedVideos.Add(selectedVideo);
            wmpForm3.URL = selectedVideo;  // Set the URL to the selected video
            resultVideo = selectedVideo.Contains("six") ? "Six" :
                          selectedVideo.Contains("four") ? "Four" : "Out";  // Determine the result based on the video name

            // Start the video and enable the timer
            wmpForm3.Ctlcontrols.play();  // Play the video
            cricketTimer.Interval = 100;
            cricketTimer.Enabled = true;  // Enable the timer to track video position
        }


    }
}