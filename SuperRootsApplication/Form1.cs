using System;
using System.Linq;
using System.Windows.Forms;

namespace SuperRootsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = trackBar1.Value;
            string result = "";                  
            string s = Math.Pow(Double.Parse(textBox1.Text), 1 / Double.Parse(textBox2.Text)).ToString();
            
            int doti = s.IndexOf(',');
            if (s.Contains(',') && a != 0)
                result = s.Substring(0, doti) + s.Substring(doti, a + 1);
            else
                if (doti == -1)
                result = s;
            else
                result = s.Substring(0, doti);
            Console.WriteLine(result);
            textBox1.Text = result;
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
    }
}
