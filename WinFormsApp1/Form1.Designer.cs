namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            calculateButton = new Button();
            panel1 = new Panel();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            exitButton = new Button();
            wordButton = new Button();
            excelButton = new Button();
            clearButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            calculateButton.BackColor = Color.DimGray;
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            calculateButton.ForeColor = Color.WhiteSmoke;
            calculateButton.Location = new Point(1052, 195);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(200, 90);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Рассчитать";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 80);
            panel1.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top;
            textBox7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(1078, 12);
            textBox7.MaxLength = 15;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(174, 32);
            textBox7.TabIndex = 20;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top;
            textBox6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(901, 12);
            textBox6.MaxLength = 15;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(171, 32);
            textBox6.TabIndex = 19;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top;
            textBox5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(724, 13);
            textBox5.MaxLength = 15;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 32);
            textBox5.TabIndex = 18;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top;
            textBox4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(547, 13);
            textBox4.MaxLength = 15;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 32);
            textBox4.TabIndex = 18;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(370, 13);
            textBox3.MaxLength = 15;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 32);
            textBox3.TabIndex = 17;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(189, 13);
            textBox2.MaxLength = 15;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 32);
            textBox2.TabIndex = 16;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(12, 13);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 32);
            textBox1.TabIndex = 15;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(1154, 48);
            label7.Name = "label7";
            label7.Size = new Size(25, 25);
            label7.TabIndex = 14;
            label7.Text = "D";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(971, 48);
            label6.Name = "label6";
            label6.Size = new Size(24, 25);
            label6.TabIndex = 13;
            label6.Text = "C";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(798, 48);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 12;
            label5.Text = "B";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(619, 48);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 11;
            label4.Text = "A";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(365, 48);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 10;
            label3.Text = "Z координата точки";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(183, 48);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 9;
            label2.Text = "Y координата точки";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(5, 48);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 8;
            label1.Text = "X координата точки";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top;
            textBox8.Enabled = false;
            textBox8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(12, 86);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(1240, 31);
            textBox8.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(533, 120);
            label8.Name = "label8";
            label8.Size = new Size(185, 50);
            label8.TabIndex = 15;
            label8.Text = "Результат";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(5, 285);
            label9.Name = "label9";
            label9.Size = new Size(746, 384);
            label9.TabIndex = 16;
            label9.Text = resources.GetString("label9.Text");
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.BackColor = Color.DimGray;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.WhiteSmoke;
            exitButton.Location = new Point(1052, 579);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 90);
            exitButton.TabIndex = 18;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // wordButton
            // 
            wordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            wordButton.BackColor = Color.DimGray;
            wordButton.FlatStyle = FlatStyle.Flat;
            wordButton.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            wordButton.ForeColor = Color.WhiteSmoke;
            wordButton.Location = new Point(1052, 387);
            wordButton.Name = "wordButton";
            wordButton.Size = new Size(200, 90);
            wordButton.TabIndex = 19;
            wordButton.Text = "Показать в Word";
            wordButton.UseVisualStyleBackColor = false;
            wordButton.Click += wordButton_Click;
            // 
            // excelButton
            // 
            excelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            excelButton.BackColor = Color.DimGray;
            excelButton.FlatStyle = FlatStyle.Flat;
            excelButton.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            excelButton.ForeColor = Color.WhiteSmoke;
            excelButton.Location = new Point(1052, 483);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(200, 90);
            excelButton.TabIndex = 20;
            excelButton.Text = "Показать в Excel";
            excelButton.UseVisualStyleBackColor = false;
            excelButton.Click += excelButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearButton.BackColor = Color.DimGray;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = Color.WhiteSmoke;
            clearButton.Location = new Point(1052, 291);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(200, 90);
            clearButton.TabIndex = 21;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1264, 681);
            Controls.Add(clearButton);
            Controls.Add(excelButton);
            Controls.Add(wordButton);
            Controls.Add(exitButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(calculateButton);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
        private Button exitButton;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button wordButton;
        private Button excelButton;
        private Button clearButton;
    }
}