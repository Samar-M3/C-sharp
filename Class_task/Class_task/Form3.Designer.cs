namespace Class_task
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            obt_marks = new Label();
            totalmarkslbl = new Label();
            output = new Label();
            percentbtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(332, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // obt_marks
            // 
            obt_marks.AutoSize = true;
            obt_marks.Location = new Point(139, 20);
            obt_marks.Name = "obt_marks";
            obt_marks.Size = new Size(108, 20);
            obt_marks.TabIndex = 3;
            obt_marks.Text = "marksobtained";
            // 
            // totalmarkslbl
            // 
            totalmarkslbl.AutoSize = true;
            totalmarkslbl.Location = new Point(330, 20);
            totalmarkslbl.Name = "totalmarkslbl";
            totalmarkslbl.Size = new Size(79, 20);
            totalmarkslbl.TabIndex = 4;
            totalmarkslbl.Text = "totalmarks";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(507, 176);
            output.Name = "output";
            output.Size = new Size(53, 20);
            output.TabIndex = 5;
            output.Text = "output";
            output.Visible = false;
            // 
            // percentbtn
            // 
            percentbtn.Location = new Point(203, 150);
            percentbtn.Name = "percentbtn";
            percentbtn.Size = new Size(194, 73);
            percentbtn.TabIndex = 6;
            percentbtn.Text = "calculate percentage";
            percentbtn.UseVisualStyleBackColor = true;
            percentbtn.Click += percentbtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(percentbtn);
            Controls.Add(output);
            Controls.Add(totalmarkslbl);
            Controls.Add(obt_marks);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label obt_marks;
        private Label totalmarkslbl;
        private Label output;
        private Button percentbtn;
    }
}