using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using FParsec;


namespace SuperRootsApplication
{
    public partial class SuperRootCalculator : Form
    {
        
        public static int NumberLanguage = 0;
        int Nlanguage
        {
            get
            { 
                return NumberLanguage; 
            }

            set
            {
                NumberLanguage = value;

                ToolStripMenuItem.Text = file[Nlanguage];
                выходToolStripMenuItem.Text = exit[Nlanguage];
                оПрограммеToolStripMenuItem.Text = aboutProgramm[Nlanguage];
                руководствоПользователяToolStripMenuItem.Text = userManual[Nlanguage];
                языкToolStripMenuItem.Text = language[Nlanguage];
                справкаToolStripMenuItem.Text = help[Nlanguage];

                AccuracyLabel.Text = accuracy[Nlanguage];
                LabelForAnswer.Text = answer[Nlanguage];
                ButtonForCalculate.Text = calculate[Nlanguage];

                check.Checked = false;
                checkBox1.Checked = false;

                check.Text = analyticalRoots[Nlanguage];
                checkBox1.Text = complexRoots[Nlanguage];

                LabelForTextBox1.Text = sqrt[Nlanguage];
                LabelForTextBox2.Text = "";
            }
        }
    
        public SuperRootCalculator()
        {
           
            InitializeComponent();
        }

        static List<string> file = new List<string>() { "Файл","File" };
        static List<string> exit = new List<string>() { "Выход", "Exit" };
        static List<string> aboutProgramm = new List<string>() { "О программе", "About the program" };
        static List<string> userManual = new List<string>() { "Руководство пользователя", "User manual" };
        static List<string> language = new List<string>() { "Язык", "Language" };
        static List<string> help = new List<string>() { "Справка", "Help" };
        static List<string> answer = new List<string>() { "Ответ:", "Result:" };

        static List<string> createFile = new List<string>() { "Создать файл", "Create file" };
        static List<string> choose = new List<string>() { "Выбрать другой язык", "Choose a different language" };

        static List<string> sqrt = new List<string>() { "Введите число", "Enter a number" };

        static List<string> isqrtRe = new List<string>() { "Введите вещественную часть", "Enter the real part" };
        static List<string> isqrtIm = new List<string>() { "Введите мнимую часть", "Enter the imaginary part" };
        static List<string> ANALsqrt = new List<string>() { "Введите выражение", "Enter the expression" };
        static List<string> calculate = new List<string>() { "Расчитать", "Calculate" };
        static List<string> analyticalRoots = new List<string>() { "Аналитические корни", "Analytical roots" };
        static List<string> complexRoots = new List<string>() { "Комплексные корни", "Complex roots" };
        static List<string> accuracy = new List<string>() { "Точность", "Accuracy" };

        public static List<string> errorNonNumber = new List<string>() { "не число", "Not a number" };
        public static List<string> errorFormat = new List<string>() { "Неправильный формат ввода", "Incorrect input format" };
        public static List<string> errors = new List<string>() { "Были ошибки, возможен не тот результат", "There were mistakes, the wrong result is possible" };
        public static List<string> errorCalculate = new List<string>() { "Такое программа посчитать не может", "The program cannot calculate this" };
        public static List<string> errorLoadLanguage = new List<string>() { "Ошибка в количестве строк в языковом файле", "Error in the number of lines in the language file" };

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
                if(res == errorNonNumber[Nlanguage] || res == errorFormat[Nlanguage] || res == errorCalculate[Nlanguage])
                {
                    Error error = new Error(res);
                    error.ShowDialog(this);
                    label6.Text = "";
                }
                else
                {
                    label6.Text = $"{res}";
                }                
            }
            else if (checkBox1.Checked) {
                bool real = double.TryParse(textBox1.Text, out double re);
                bool image = double.TryParse(textBox2.Text, out double im);
                if (real && image)
                {
                    if(re == 0 && im == 0)
                    {
                        textBox3.Text = "0";
                    }
                    else
                    {
                        var t = RootCalculator.ISqrt(re, im, trackBar1.Value);
                        textBox3.Text = "+/-(" + t.Item1.ToString() + "+" + t.Item2.ToString() + "i)";
                    }
                    
                }
                else if (real)
                {
                    Error error = new Error(errors[Nlanguage]);
                    error.ShowDialog(this);
                    var t = RootCalculator.ISqrt(re, 0, trackBar1.Value);
                    label6.Text = "+/-(" + t.Item1.ToString() + "+" + t.Item2.ToString() + "i)";
                }
                else if (image)
                {
                    Error error = new Error(errors[Nlanguage]);
                    error.ShowDialog(this);
                    var t = RootCalculator.ISqrt(0, im, trackBar1.Value);
                    label6.Text = "+/-(" + t.Item1.ToString() + "+" + t.Item2.ToString() + "i)";
                }
                if (!real && !image)
                {
                    Error error = new Error(errorFormat[Nlanguage]);
                    error.ShowDialog(this);
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
                LabelForTextBox1.Text = ANALsqrt[Nlanguage];
                LabelForTextBox2.Text = "";

                textBox2.Text = "";
                textBox2.Enabled = false;     
                
                checkBox1.Enabled = false;
            }
            else
            {
                LabelForTextBox1.Text = sqrt[Nlanguage];
                LabelForTextBox2.Text = "";

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
                LabelForTextBox2.Text = isqrtIm[Nlanguage];
                LabelForTextBox1.Text = isqrtRe[Nlanguage];

                textBox1.Text = "0";


                textBox2.Enabled = true;
                textBox2.Text = "0";
                
                check.Enabled = false;
            }
            else
            {
                LabelForTextBox1.Text = sqrt[Nlanguage];
                LabelForTextBox2.Text = "";

                textBox2.Text = "";
                textBox2.Enabled = false;
                
                check.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new about_the_program(version[Nlanguage], developers[Nlanguage]);
            about.ShowDialog();
        }
        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var guide = new users_guide();
            guide.ShowDialog();
        }

        private void SuperRootCalculator_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(750,489);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void языкToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выбратьДрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                openFileDialog.InitialDirectory = directory;
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        file.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        exit.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        aboutProgramm.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        userManual.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        language.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        help.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        answer.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        sqrt.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        isqrtRe.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        isqrtIm.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        ANALsqrt.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        calculate.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        analyticalRoots.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        complexRoots.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        accuracy.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }

                        errorNonNumber.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        errorFormat.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        errors.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        errorCalculate.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }
                        errorLoadLanguage.Add(reader.ReadLine());
                        if (reader.EndOfStream)
                        {
                            Error error = new Error(errorLoadLanguage[Nlanguage]);
                            error.ShowDialog(this);
                            return;
                        }

                        Nlanguage = file.Count - 1;
                    }
                }
            }
        }
        private void русскийЯзыкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 0;
        }

        private void englishLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 1;
        }
        private void создатьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = File.CreateText("EnglishLanguage.txt");

            f.WriteLine(file[1]);
            f.WriteLine(exit[1]);

            f.WriteLine(aboutProgramm[1]);
            f.WriteLine(userManual[1]);
            f.WriteLine(language[1]);
            f.WriteLine(help[1]);

            f.WriteLine(answer[1]);
            f.WriteLine(createFile[1]);
            f.WriteLine(choose[1]);

            f.WriteLine(sqrt[1]);
            f.WriteLine(isqrtRe[1]);
            f.WriteLine(isqrtIm[1]);

            f.WriteLine(ANALsqrt[1]);
            f.WriteLine(calculate[1]);


            f.WriteLine(analyticalRoots[1]);
            

            f.WriteLine(complexRoots[1]);
            f.WriteLine(accuracy[1]);

            f.WriteLine(errorNonNumber[1]);
            f.WriteLine(errorFormat[1]);
            f.WriteLine(errors[1]);
            f.WriteLine(errorCalculate[1]);
            f.WriteLine(errorLoadLanguage[1]);

            f.WriteLine(version[1]);
            f.WriteLine(developers[1]);
            f.Flush();
            f.Close();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bool can = int.TryParse(toolStripTextBox1.Text, out var n);
                n -= 1;
                if (can)
                {
                    if(n < file.Count)
                    {
                        if(n >= 0)
                        {
                            Nlanguage = n;
                        }
                        else
                        {
                            Nlanguage = 0;
                        }
                    }
                    else
                    {
                        Nlanguage = file.Count-1;
                    }
                }
                else
                {
                    toolStripTextBox1.Text = sqrt[Nlanguage];
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
