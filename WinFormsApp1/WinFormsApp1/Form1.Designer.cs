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
            label1 = new Label();
            this.add = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            this.subtract = new Button();
            this.multiply = new Button();
            divide = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "number1";
            label1.Click += label1_Click;
            // 
            // add
            // 
            this.btnadd.Location = new Point(17, 141);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new Size(94, 29);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += this.button1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.WaitCursor;
            textBox1.Location = new Point(96, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 63);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "number2";
            // 
            // subtract
            // 
            this.btnsubtract.Location = new Point(127, 141);
            this.btnsubtract.Name = "btnsubtract";
            this.btnsubtract.Size = new Size(94, 29);
            this.btnsubtract.TabIndex = 5;
            this.btnsubtract.Text = "subtract";
            this.btnsubtract.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.btnmultiply.Location = new Point(236, 141);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new Size(94, 29);
            this.btnmultiply.TabIndex = 6;
            this.btnmultiply.Text = "multiply";
            this.btnmultiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.btndivide.Location = new Point(350, 141);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new Size(94, 29);
            this.btndivide.TabIndex = 7;
            this.btndivide.Text = "divide";
            divide.UseVisualStyleBackColor = true;
            divide.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(divide);
            Controls.Add(this.multiply);
            Controls.Add(this.subtract);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(this.add);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button divide;
    }
}
