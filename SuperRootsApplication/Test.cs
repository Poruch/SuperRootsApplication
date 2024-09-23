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
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            LanguageLoader.SetTranslation(directory + "/RussianLanguage.txt");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked || check.Checked))
            {
                bool real = double.TryParse(textBox1.Text, out double re);              
                if (real)
                {
                    label6.Text = RootCalculator.Sqrt(re, trackBar1.Value).ToString();
                }
            }
            else if (check.Checked) {
                var res = RootCalculator.ANALRoot(textBox1.Text, trackBar1.Value);
                label6.Text = $"{res}";
            }
            else if (checkBox1.Checked) {
                bool real = double.TryParse(textBox1.Text, out double re);
                bool image = double.TryParse(textBox2.Text, out double im);
                if (real && image)
                {
                    var t = RootCalculator.ISqrt(re, im, trackBar1.Value);
                    label6.Text = "+/-(" + t.Item1.ToString() + "+" + t.Item2.ToString() + "i)";
                }
                else if (real)
                {
                    label6.Text = RootCalculator.Sqrt(re, trackBar1.Value).ToString();
                }
                else if (image)
                {
                    var t = RootCalculator.ISqrt(0, im, trackBar1.Value);
                    label6.Text = "+/-(" + t.Item1.ToString() + "+" + t.Item2.ToString() + "i)";
                }
                if (!real)
                {

                }
                if (!image)
                {

                }
            }
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
            textBox1.Text = "";
            if (check.Checked)
            {
                label1.Text = "Введите выражение";
                label3.Text = "";

                textBox2.Text = "";
                textBox2.Enabled = false;     
                
                checkBox1.Enabled = false;
            }
            else
            {
                label1.Text = "Введите число";
                label3.Text = "";

                textBox2.Text = "";
                textBox2.Enabled = false;               
                checkBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (checkBox1.Checked)
            {
                label3.Text = "Введите мнимую часть";
                label1.Text = "Введите вещественную часть";

                textBox1.Text = "0";


                textBox2.Enabled = true;
                textBox2.Text = "0";
                
                check.Enabled = false;
            }
            else
            {
                label1.Text = "Введите число";
                label3.Text = "";

                textBox2.Text = "";
                textBox2.Enabled = false;
                
                check.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        about_the_program about_the_program;
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_the_program = new about_the_program();
            about_the_program.Show();
        }
        users_guide users_guide;
        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users_guide = new users_guide();
            users_guide.Show();
        }

        private void SuperRootCalculator_Load(object sender, EventArgs e)
        {

        }

        private void языкToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выбратьДрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
