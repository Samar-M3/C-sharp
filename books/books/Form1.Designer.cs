namespace books
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Display = new Button();
            Clear = new Button();
            blockkey = new Label();
            title = new Label();
            pages = new Label();
            deletebtn = new Button();
            btnEditTitle = new Button();
            exitbtn = new Button();
            listBox1 = new ListBox();
            insert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Books Records";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(513, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(513, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(513, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(70, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 27);
            textBox4.TabIndex = 5;
            //textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Display
            // 
            Display.Location = new Point(45, 221);
            Display.Name = "Display";
            Display.Size = new Size(94, 29);
            Display.TabIndex = 6;
            Display.Text = "Display";
            Display.UseVisualStyleBackColor = true;
            Display.Click += Display_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(210, 221);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 7;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            // 
            // blockkey
            // 
            blockkey.AutoSize = true;
            blockkey.Location = new Point(420, 67);
            blockkey.Name = "blockkey";
            blockkey.Size = new Size(67, 20);
            blockkey.TabIndex = 8;
            blockkey.Text = "blockkey";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(421, 125);
            title.Name = "title";
            title.Size = new Size(35, 20);
            title.TabIndex = 9;
            title.Text = "title";
            // 
            // pages
            // 
            pages.AutoSize = true;
            pages.Location = new Point(414, 177);
            pages.Name = "pages";
            pages.Size = new Size(49, 20);
            pages.TabIndex = 10;
            pages.Text = "pages";
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(70, 382);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 29);
            deletebtn.TabIndex = 11;
            deletebtn.Text = "delete";
            deletebtn.UseVisualStyleBackColor = true;
            // 
            // btnEditTitle
            // 
            btnEditTitle.Location = new Point(40, 325);
            btnEditTitle.Name = "btnEditTitle";
            btnEditTitle.Size = new Size(94, 29);
            btnEditTitle.TabIndex = 12;
            btnEditTitle.Text = "edit title";
            btnEditTitle.UseVisualStyleBackColor = true;
            btnEditTitle.Click += btnEditTitle_Click;
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(619, 402);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(94, 29);
            exitbtn.TabIndex = 13;
            exitbtn.Text = "exit";
            exitbtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(45, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 14;
            // 
            // insert
            // 
            insert.Location = new Point(558, 223);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 15;
            insert.Text = "insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(insert);
            Controls.Add(listBox1);
            Controls.Add(exitbtn);
            Controls.Add(btnEditTitle);
            Controls.Add(deletebtn);
            Controls.Add(pages);
            Controls.Add(title);
            Controls.Add(blockkey);
            Controls.Add(Clear);
            Controls.Add(Display);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Display;
        private Button Clear;
        private Label blockkey;
        private Label title;
        private Label pages;
        private Button deletebtn;
        private Button btnEditTitle;
        private Button exitbtn;
        private ListBox listBox1;
        private Button insert;
    }
}
