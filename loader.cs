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
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }

        private void loader_Load(object sender, EventArgs e)
        {
            wmpPlayer.URL = "C:\\Users\\HORIZON\\Desktop\\c#projectbett\\bett\\pictures\\loader.mp4"; // Replace with your video path
            wmpPlayer.Ctlcontrols.play();
            timer1.Start(); // Start the timer to monitor the video playback
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check if the video has reached 22 seconds
            if (wmpPlayer.Ctlcontrols.currentPosition >= 22)
            {
                wmpPlayer.Ctlcontrols.pause(); // Pause the video at 22 seconds
                timer1.Stop(); // Stop the timer
                this.Hide(); // Hide the loader form
                Form1 welcomeForm = new Form1(); // Create an instance of Form1
                welcomeForm.Show(); // Show the welcome form
            }
        }
    }
}
