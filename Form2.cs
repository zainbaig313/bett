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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 circket = new Form3();
            this.Hide(); // Hide 
            circket.ShowDialog(); // Show  form as modal
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flip_a_coin flip_A_Coin = new Flip_a_coin();
            this.Hide(); // Hide 
            flip_A_Coin.ShowDialog(); // Show  form as modal
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Football football = new Football();
            this.Hide(); // Hide 
            football.ShowDialog(); // Show  form as modal
            this.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelCoinsForm2.Text = $"{GameManager.Coins}";
        }
    }
}
