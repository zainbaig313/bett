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
    public partial class Flip_a_coin : Form
    {
        public Flip_a_coin()
        {
            InitializeComponent();
        }

        private void Flip_a_coin_Load(object sender, EventArgs e)
        {
            radioButtonHead.Checked = false;  // Ensure Head is not selected by default
            radioButtonTail.Checked = false;
            UpdateCoinDisplay();
        }

        private void btnPlayFlipaCoin_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if user has 0 coins
                if (GameManager.Coins == 0)
                {
                    MessageBox.Show("You have 0 coins. You cannot place a bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if a betting amount is selected
                if (CbBettingAmountFlipaCoin.SelectedItem == null)
                {
                    MessageBox.Show("Please select a betting amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse the bet amount
                int betAmountFlipaCoin = int.Parse(CbBettingAmountFlipaCoin.SelectedItem.ToString());

                // Check if the user has enough coins for the bet
                if (betAmountFlipaCoin > GameManager.Coins)
                {
                    MessageBox.Show("Not enough coins to place the bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure user makes a selection between Head or Tail
                string userChoiceFlipaCoin = radioButtonHead.Checked ? "Head" : radioButtonTail.Checked ? "Tail" : "";

                if (string.IsNullOrEmpty(userChoiceFlipaCoin))
                {
                    MessageBox.Show("Please select Head or Tail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Random random = new Random();
                string systemChoiceFLipaCoin = random.Next(2) == 0 ? "Head" : "Tail";

                if (userChoiceFlipaCoin == systemChoiceFLipaCoin)
                {
                    int winningsFlipaCoin = (int)(betAmountFlipaCoin * 0.7);
                    GameManager.Coins += winningsFlipaCoin;

                    resultFlipaCoin.Text = $"You win! Coins increased by {winningsFlipaCoin}.";
                }
                else
                {
                    GameManager.Coins -= betAmountFlipaCoin;

                    // Check if coins go below 0
                    if (GameManager.Coins < 0)
                    {
                        throw new InvalidOperationException("Insufficient coins. You cannot continue betting.");
                    }

                    resultFlipaCoin.Text = $"You lose! Coins decreased by {betAmountFlipaCoin}.";
                }
            }
            catch (FormatException ex)
            {
                // Handle incorrect format for bet amount
                MessageBox.Show("Invalid bet amount format. Please select a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                // Handle coins going below zero
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Reset coins to 0
                GameManager.Coins = 0;
            }
            catch (Exception ex)
            {
                // Handle other unforeseen errors
                MessageBox.Show("An error occurred while processing the game. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Always update the coin display regardless of success or failure
                UpdateCoinDisplay();
            }

            CbBettingAmountFlipaCoin.SelectedItem = null;
            radioButtonHead.Checked = false;
            radioButtonTail.Checked = false;
        }


        private void UpdateCoinDisplay()
        {
            labelCoinsFlipacoin.Text = $"{GameManager.Coins}";
        }

        
    }
}
