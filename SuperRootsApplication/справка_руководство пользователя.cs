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
        public users_guide()
        {
            InitializeComponent();
        }

        private void users_guide_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(750, 489);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
