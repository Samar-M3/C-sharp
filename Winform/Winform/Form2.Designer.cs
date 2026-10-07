namespace Winform
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
            components = new System.ComponentModel.Container();
            lblUtcTime = new Label();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblUtcTime
            // 
            lblUtcTime.AutoSize = true;
            lblUtcTime.Location = new Point(160, 67);
            lblUtcTime.Name = "lblUtcTime";
            lblUtcTime.Size = new Size(35, 20);
            lblUtcTime.TabIndex = 0;
            lblUtcTime.Text = "UTC";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(232, 67);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(51, 20);
            lblTime.TabIndex = 1;
            lblTime.Text = "TIMER";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTime);
            Controls.Add(lblUtcTime);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUtcTime;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}