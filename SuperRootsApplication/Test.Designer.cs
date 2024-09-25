namespace SuperRootsApplication
{
    partial class SuperRootCalculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonForCalculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelForTextBox1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelForTextBox2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.AccuracyLabel = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelForAnswer = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийЯзыкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьДрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonForCalculate
            // 
            this.ButtonForCalculate.BackColor = System.Drawing.SystemColors.Menu;
            this.ButtonForCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonForCalculate.Location = new System.Drawing.Point(429, 269);
            this.ButtonForCalculate.Name = "ButtonForCalculate";
            this.ButtonForCalculate.Size = new System.Drawing.Size(116, 32);
            this.ButtonForCalculate.TabIndex = 0;
            this.ButtonForCalculate.Text = "Рассчитать";
            this.ButtonForCalculate.UseVisualStyleBackColor = false;
            this.ButtonForCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(226, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // LabelForTextBox1
            // 
            this.LabelForTextBox1.AutoSize = true;
            this.LabelForTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForTextBox1.Location = new System.Drawing.Point(220, 93);
            this.LabelForTextBox1.Name = "LabelForTextBox1";
            this.LabelForTextBox1.Size = new System.Drawing.Size(212, 31);
            this.LabelForTextBox1.TabIndex = 2;
            this.LabelForTextBox1.Text = "Введите число";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(226, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LabelForTextBox2
            // 
            this.LabelForTextBox2.AutoSize = true;
            this.LabelForTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForTextBox2.Location = new System.Drawing.Point(223, 170);
            this.LabelForTextBox2.Name = "LabelForTextBox2";
            this.LabelForTextBox2.Size = new System.Drawing.Size(0, 31);
            this.LabelForTextBox2.TabIndex = 8;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 393);
            this.trackBar1.Maximum = 13;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.AutoSize = true;
            this.AccuracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccuracyLabel.Location = new System.Drawing.Point(12, 370);
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(80, 20);
            this.AccuracyLabel.TabIndex = 10;
            this.AccuracyLabel.Text = "Точность";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check.Location = new System.Drawing.Point(226, 243);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(194, 24);
            this.check.TabIndex = 11;
            this.check.Text = "Аналитические корни";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.checkBox1_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LabelForAnswer
            // 
            this.LabelForAnswer.AutoSize = true;
            this.LabelForAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForAnswer.Location = new System.Drawing.Point(224, 325);
            this.LabelForAnswer.Name = "LabelForAnswer";
            this.LabelForAnswer.Size = new System.Drawing.Size(83, 25);
            this.LabelForAnswer.TabIndex = 14;
            this.LabelForAnswer.Text = "Ответ:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(225, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Комплексные корни";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.языкToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.руководствоПользователяToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            this.руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            this.руководствоПользователяToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            this.руководствоПользователяToolStripMenuItem.Click += new System.EventHandler(this.руководствоПользователяToolStripMenuItem_Click);
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийЯзыкToolStripMenuItem,
            this.englishLanguageToolStripMenuItem,
            this.toolStripTextBox1,
            this.выбратьДрToolStripMenuItem,
            this.создатьФайлToolStripMenuItem});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.языкToolStripMenuItem.Text = "Язык";
            this.языкToolStripMenuItem.Click += new System.EventHandler(this.языкToolStripMenuItem_Click);
            // 
            // русскийЯзыкToolStripMenuItem
            // 
            this.русскийЯзыкToolStripMenuItem.Name = "русскийЯзыкToolStripMenuItem";
            this.русскийЯзыкToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.русскийЯзыкToolStripMenuItem.Text = "1 Русский язык";
            this.русскийЯзыкToolStripMenuItem.Click += new System.EventHandler(this.русскийЯзыкToolStripMenuItem_Click);
            // 
            // englishLanguageToolStripMenuItem
            // 
            this.englishLanguageToolStripMenuItem.Name = "englishLanguageToolStripMenuItem";
            this.englishLanguageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.englishLanguageToolStripMenuItem.Text = "2 English language";
            this.englishLanguageToolStripMenuItem.Click += new System.EventHandler(this.englishLanguageToolStripMenuItem_Click);
            // 
            // выбратьДрToolStripMenuItem
            // 
            this.выбратьДрToolStripMenuItem.Name = "выбратьДрToolStripMenuItem";
            this.выбратьДрToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.выбратьДрToolStripMenuItem.Text = "Выбрать другой язык";
            this.выбратьДрToolStripMenuItem.Click += new System.EventHandler(this.выбратьДрToolStripMenuItem_Click);
            // 
            // создатьФайлToolStripMenuItem
            // 
            this.создатьФайлToolStripMenuItem.Name = "создатьФайлToolStripMenuItem";
            this.создатьФайлToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.создатьФайлToolStripMenuItem.Text = "Создать файл";
            this.создатьФайлToolStripMenuItem.Click += new System.EventHandler(this.создатьФайлToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(314, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(231, 20);
            this.textBox3.TabIndex = 17;
            // 
            // SuperRootCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LabelForAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.check);
            this.Controls.Add(this.AccuracyLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LabelForTextBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LabelForTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonForCalculate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SuperRootCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperRootCalculator";
            this.Load += new System.EventHandler(this.SuperRootCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonForCalculate;
        private System.Windows.Forms.Label LabelForTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LabelForTextBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label AccuracyLabel;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelForAnswer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийЯзыкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьДрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

