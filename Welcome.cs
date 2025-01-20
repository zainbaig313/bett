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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            this.Hide(); // Hide Form1
            login.ShowDialog(); // Show Login form as modal
            this.Show();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide(); // Hide Form1
            signup.ShowDialog(); // Show Login form as modal
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
