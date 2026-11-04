namespace sumNumbersBackground
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(90, 51);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(137, 47);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate Sum";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 11F);
            lblResult.Location = new Point(46, 147);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(66, 25);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 240);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Sum Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}