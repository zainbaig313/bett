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
    public partial class Football : Form
    {
        private string resultVideo; // To store the result type ("Goal" or "Miss")
        private List<string> allVideos = new List<string>
        {
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\miss1.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\miss2.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\miss3.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\miss4.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\miss5.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\miss6.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\miss7.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\goal1.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\goal2.mp4",
            "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\footballVideos\\goal3.mp4"
        };

        private List<string> playedVideos = new List<string>(); // To track played videos
        private Random random = new Random(); // For random selection
        private double stoppedAt = 0; // Variable to store the stopping position

        public Football()
        {
            InitializeComponent();
        }

        private void Football_Load(object sender, EventArgs e)
        {
            wmpFootball.uiMode = "none";
            radioButtonGoal.Checked = false;
            radioButtonMiss.Checked = false;
            labelCoinsFootball.Text = $"{GameManager.Coins}";
        }

        private void footballTimer_Tick(object sender, EventArgs e)
        {
            if (wmpFootball.Ctlcontrols.currentPosition >= 10)
            {
                stoppedAt = wmpFootball.Ctlcontrols.currentPosition;
                wmpFootball.Ctlcontrols.pause();
                footballTimer.Enabled = false;
                MessageBox.Show("Select your betting amount and choose Goal or Miss!");
            }
        }

        private void btnPlayFootball_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if user has 0 coins
                if (GameManager.Coins == 0)
                {
                    MessageBox.Show("You have 0 coins. You cannot place a bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CbBettingAmountFootball.SelectedItem == null)
                {
                    MessageBox.Show("Please select a betting amount.");
                    return;
                }

                // Parse the bet amount
                int betAmountFootball = int.Parse(CbBettingAmountFootball.SelectedItem.ToString());

                // Check if the user has enough coins for the bet
                if (betAmountFootball > GameManager.Coins)
                {
                    MessageBox.Show("Not enough coins to place the bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!radioButtonGoal.Checked && !radioButtonMiss.Checked)
                {
                    MessageBox.Show("Please select Goal or Miss.");
                    return;
                }

                wmpFootball.Ctlcontrols.currentPosition = stoppedAt;
                wmpFootball.Ctlcontrols.play();
                wmpFootball.PlayStateChange += WmpFootball_PlayStateChange;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }


        private void WmpFootball_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            try
            {
                if (e.newState == 8) // 8 = Stopped
                {
                    // Check if the betting amount is selected before proceeding
                    if (CbBettingAmountFootball.SelectedItem == null)
                    {
                        CbBettingAmountFootball.BackColor = Color.White;

                        return; // Exit the method early if no betting amount is selected
                    }

                    string userChoice = radioButtonGoal.Checked ? "Goal" : "Miss";
                    int bettingAmount = int.Parse(CbBettingAmountFootball.SelectedItem.ToString());

                    if (userChoice == resultVideo)
                    {
                        int winnings = (int)(bettingAmount * 0.7);
                        GameManager.Coins += winnings;
                        resultFootball.Text = $"You are correct! It was {resultVideo}. Coins increased by {winnings}.";
                    }
                    else
                    {
                        GameManager.Coins -= bettingAmount;

                        // Check if coins go below 0
                        if (GameManager.Coins < 0)
                        {
                            throw new InvalidOperationException("Insufficient coins. You cannot continue betting.");
                        }

                        resultFootball.Text = $"You are wrong! It was {resultVideo}. Coins decreased by {bettingAmount}.";
                    }

                    labelCoinsFootball.Text = GameManager.Coins.ToString();

                    // Reset betting controls after the video ends
                    CbBettingAmountFootball.SelectedIndex = -1;  // Use SelectedIndex to clear selection
                    radioButtonGoal.Checked = false;
                    radioButtonMiss.Checked = false;
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
                labelCoinsFootball.Text = GameManager.Coins.ToString();
            }
            catch (Exception ex)
            {
                // Handle unforeseen errors
                MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }


        private void btnStartFootball_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if user has 0 coins
                if (GameManager.Coins == 0)
                {
                    MessageBox.Show("You have 0 coins. You cannot start the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (playedVideos.Count == allVideos.Count)
                {
                    MessageBox.Show("We are out of videos. Please come back later!");
                    return;
                }

                string selectedVideo;
                do
                {
                    selectedVideo = allVideos[random.Next(allVideos.Count)];
                } while (playedVideos.Contains(selectedVideo));

                playedVideos.Add(selectedVideo);
                wmpFootball.URL = selectedVideo;
                resultVideo = selectedVideo.Contains("goal") ? "Goal" : "Miss";

                wmpFootball.Ctlcontrols.play();
                footballTimer.Interval = 100;
                footballTimer.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

    }
}
