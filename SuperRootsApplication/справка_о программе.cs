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
    public partial class about_the_program : Form
    {
        public about_the_program(string v,string d)
        {
            InitializeComponent();
            label2.Text = v;
            label3.Text = d;
        }

        private void about_the_program_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(400, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
