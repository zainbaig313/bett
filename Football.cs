﻿using System;
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
        public Football()
        {
            InitializeComponent();
        }

        private void Football_Load(object sender, EventArgs e)
        {
            labelCoinsFootball.Text = $"{GameManager.Coins}";
        }
    }
}
