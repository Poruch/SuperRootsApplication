using System;
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
    public partial class users_guide : Form
    {
        public users_guide(string user_manual,string feedback)
        {
            InitializeComponent();
            label1.Text = user_manual;
            label2.Text = feedback;
        }

        private void users_guide_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(600, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(linkLabel1.Text);
            }
            catch 
            {

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(linkLabel2.Text);
            }
            catch
            {

            }
        }
    }
}
