namespace Winform
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnrightshift = new Button();
            exit = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            leftshiftbtn = new Button();
            letteraddbtn = new Button();
            numberaddbtn = new Button();
            numbersort = new Button();
            lettersort = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 73);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "list of letters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 71);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "list of numbers";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D" });
            listBox1.Location = new Point(37, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Items.AddRange(new object[] { "1", "2", "3", "4" });
            listBox2.Location = new Point(253, 115);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 4;
            // 
            // btnrightshift
            // 
            btnrightshift.Location = new Point(66, 234);
            btnrightshift.Name = "btnrightshift";
            btnrightshift.Size = new Size(94, 29);
            btnrightshift.TabIndex = 5;
            btnrightshift.Text = "right shift";
            btnrightshift.UseVisualStyleBackColor = true;
            btnrightshift.Click += btnrightshift_Click;
            // 
            // exit
            // 
            exit.Location = new Point(39, 418);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 11;
            exit.Text = "exit";
            exit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(302, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            // 
            // leftshiftbtn
            // 
            leftshiftbtn.Location = new Point(299, 234);
            leftshiftbtn.Name = "leftshiftbtn";
            leftshiftbtn.Size = new Size(94, 29);
            leftshiftbtn.TabIndex = 14;
            leftshiftbtn.Text = "left shift";
            leftshiftbtn.UseVisualStyleBackColor = true;
            // 
            // letteraddbtn
            // 
            letteraddbtn.Location = new Point(98, 330);
            letteraddbtn.Name = "letteraddbtn";
            letteraddbtn.Size = new Size(94, 29);
            letteraddbtn.TabIndex = 15;
            letteraddbtn.Text = "add letter";
            letteraddbtn.UseVisualStyleBackColor = true;
            // 
            // numberaddbtn
            // 
            numberaddbtn.Location = new Point(319, 330);
            numberaddbtn.Name = "numberaddbtn";
            numberaddbtn.Size = new Size(94, 29);
            numberaddbtn.TabIndex = 16;
            numberaddbtn.Text = "button7";
            numberaddbtn.UseVisualStyleBackColor = true;
            numberaddbtn.Click += numberaddbtn_Click;
            // 
            // numbersort
            // 
            numbersort.Location = new Point(319, 381);
            numbersort.Name = "numbersort";
            numbersort.Size = new Size(94, 29);
            numbersort.TabIndex = 18;
            numbersort.Text = "button9";
            numbersort.UseVisualStyleBackColor = true;
            // 
            // lettersort
            // 
            lettersort.Location = new Point(117, 373);
            lettersort.Name = "lettersort";
            lettersort.Size = new Size(94, 29);
            lettersort.TabIndex = 19;
            lettersort.Text = "button1";
            lettersort.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lettersort);
            Controls.Add(numbersort);
            Controls.Add(numberaddbtn);
            Controls.Add(letteraddbtn);
            Controls.Add(leftshiftbtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(exit);
            Controls.Add(btnrightshift);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnrightshift;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button exit;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button leftshiftbtn;
        private Button letteraddbtn;
        private Button numberaddbtn;
        private Button button8;
        private Button numbersort;
        private Button lettersort;
    }
}