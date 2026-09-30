namespace Class_task
{
    partial class Form2
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
            button = new Button();
            label1 = new Label();
            output = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button
            // 
            button.Location = new Point(248, 145);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 1;
            button.Text = "button1";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 52);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter Your Name";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(454, 95);
            output.Name = "output";
            output.Size = new Size(53, 20);
            output.TabIndex = 3;
            output.Text = "output";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(label1);
            Controls.Add(button);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button;
        private Label label1;
        private Label output;
    }
}