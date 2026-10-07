namespace Datagridview
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
            panel1 = new Panel();
            country = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            emaillbl = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            namebox = new TextBox();
            addresslbl = new Label();
            Namelbl = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(country);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(emaillbl);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(namebox);
            panel1.Controls.Add(addresslbl);
            panel1.Controls.Add(Namelbl);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // country
            // 
            country.AutoSize = true;
            country.Location = new Point(64, 309);
            country.Name = "country";
            country.Size = new Size(58, 20);
            country.TabIndex = 15;
            country.Text = "country";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "nepal", "india", "china", "pakastan" });
            comboBox1.Location = new Point(162, 307);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(258, 359);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(43, 359);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Location = new Point(55, 266);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(46, 20);
            emaillbl.TabIndex = 10;
            emaillbl.Text = "email";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 263);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // namebox
            // 
            namebox.Location = new Point(177, 178);
            namebox.Name = "namebox";
            namebox.Size = new Size(125, 27);
            namebox.TabIndex = 7;
            // 
            // addresslbl
            // 
            addresslbl.AutoSize = true;
            addresslbl.Location = new Point(43, 221);
            addresslbl.Name = "addresslbl";
            addresslbl.Size = new Size(62, 20);
            addresslbl.TabIndex = 5;
            addresslbl.Text = "Address";
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Location = new Point(43, 185);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(49, 20);
            Namelbl.TabIndex = 3;
            Namelbl.Text = "Name";
            Namelbl.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(414, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 369);
            panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(380, 366);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 81);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 20);
            label1.Name = "label1";
            label1.Size = new Size(308, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome to user data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox namebox;
        private Label addresslbl;
        private Label label4;
        private Label Namelbl;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label emaillbl;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label country;
        private ComboBox comboBox1;
    }
}
