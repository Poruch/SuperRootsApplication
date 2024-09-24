﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperRootsApplication
{
    public partial class Error : Form
    {
        public Error(string s)
        {            
            InitializeComponent();
            label1.Text = s;
        }

        private void Error_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(411, 164);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
