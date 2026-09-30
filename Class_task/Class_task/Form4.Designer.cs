namespace Class_task
{
    partial class Form4
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
            username = new TextBox();
            password = new TextBox();
            login = new Button();
            output = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(213, 53);
            username.Name = "username";
            username.Size = new Size(125, 27);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(213, 125);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 1;
            // 
            // login
            // 
            login.Location = new Point(226, 202);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 2;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(402, 96);
            output.Name = "output";
            output.Size = new Size(50, 20);
            output.TabIndex = 3;
            output.Text = "label1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(login);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Button login;
        private Label output;
    }
}