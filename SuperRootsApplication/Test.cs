using System;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuperRootsApplication
{
    public partial class SuperRootCalculator : Form
    {
        public SuperRootCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chekBox1_Changed(object sender, EventArgs e)
        {

        }

        private void checkBox1_Changed(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                label1.Text = "Введите выражение";
                textBox2.Enabled = false;                
                label3.Text = "";

                //trackBar1.Enabled = false;
                //label4.Text = "";
            }
            else
            {
                label1.Text = "Введите число";
                textBox2.Enabled = true;
                label3.Text = "Введите мнимую часть числа";


                //trackBar1.Enabled = true;
                //label4.Text = "Введите точность (знаки после запятой)";
            }
        }
    }
}
