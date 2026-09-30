namespace Class_task
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
            counter = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // counter
            // 
            counter.AutoSize = true;
            counter.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            counter.Location = new Point(349, 71);
            counter.Name = "counter";
            counter.Size = new Size(70, 81);
            counter.TabIndex = 0;
            counter.Text = "0";
            counter.Click += label1_Click;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button.Location = new Point(349, 281);
            button.Name = "button";
            button.Size = new Size(94, 87);
            button.TabIndex = 1;
            button.Text = "+";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button);
            Controls.Add(counter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label counter;
        private Button button;
    }
}
