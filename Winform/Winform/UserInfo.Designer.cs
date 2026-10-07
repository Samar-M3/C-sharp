namespace Winform
{
    partial class UserInfo
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
            mainpanel = new Panel();
            btnClear = new Button();
            Add = new Button();
            comboBox1 = new ComboBox();
            radother = new RadioButton();
            radfemale = new RadioButton();
            radMale = new RadioButton();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Country = new Label();
            Gender = new Label();
            lblName = new Label();
            id = new Label();
            rightpanel = new Panel();
            dataGridView1 = new DataGridView();
            toppanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            mainpanel.SuspendLayout();
            rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toppanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveCaption;
            mainpanel.Controls.Add(btnClear);
            mainpanel.Controls.Add(Add);
            mainpanel.Controls.Add(comboBox1);
            mainpanel.Controls.Add(radother);
            mainpanel.Controls.Add(radfemale);
            mainpanel.Controls.Add(radMale);
            mainpanel.Controls.Add(textBox2);
            mainpanel.Controls.Add(textBox1);
            mainpanel.Controls.Add(Country);
            mainpanel.Controls.Add(Gender);
            mainpanel.Controls.Add(lblName);
            mainpanel.Controls.Add(id);
            mainpanel.Controls.Add(rightpanel);
            mainpanel.Controls.Add(toppanel);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(954, 450);
            mainpanel.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(244, 321);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(92, 322);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 12;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // radother
            // 
            radother.AutoSize = true;
            radother.Location = new Point(286, 206);
            radother.Name = "radother";
            radother.Size = new Size(65, 24);
            radother.TabIndex = 10;
            radother.TabStop = true;
            radother.Text = "other";
            radother.UseVisualStyleBackColor = true;
            // 
            // radfemale
            // 
            radfemale.AutoSize = true;
            radfemale.Location = new Point(202, 206);
            radfemale.Name = "radfemale";
            radfemale.Size = new Size(78, 24);
            radfemale.TabIndex = 9;
            radfemale.TabStop = true;
            radfemale.Text = "Female";
            radfemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(133, 206);
            radMale.Name = "radMale";
            radMale.Size = new Size(63, 24);
            radMale.TabIndex = 8;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(38, 241);
            Country.Name = "Country";
            Country.Size = new Size(60, 20);
            Country.TabIndex = 5;
            Country.Text = "Country";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(38, 199);
            Gender.Name = "Gender";
            Gender.Size = new Size(57, 20);
            Gender.TabIndex = 4;
            Gender.Text = "Gender";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 156);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(38, 113);
            id.Name = "id";
            id.Size = new Size(22, 20);
            id.TabIndex = 2;
            id.Text = "id";
            // 
            // rightpanel
            // 
            rightpanel.BackColor = SystemColors.GradientActiveCaption;
            rightpanel.Controls.Add(dataGridView1);
            rightpanel.Dock = DockStyle.Right;
            rightpanel.Location = new Point(593, 84);
            rightpanel.Name = "rightpanel";
            rightpanel.Size = new Size(361, 366);
            rightpanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(358, 241);
            dataGridView1.TabIndex = 0;
            // 
            // toppanel
            // 
            toppanel.BackColor = SystemColors.ButtonShadow;
            toppanel.Controls.Add(label2);
            toppanel.Controls.Add(label1);
            toppanel.Dock = DockStyle.Top;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(954, 84);
            toppanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 30);
            label2.Name = "label2";
            label2.Size = new Size(297, 38);
            label2.TabIndex = 1;
            label2.Text = "welcome to user info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(mainpanel);
            Name = "UserInfo";
            Text = "UserInfo";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel mainpanel;
        private RadioButton radother;
        private RadioButton radfemale;
        private Panel toppanel;
        private Panel rightpanel;
        //private RadioButton radioButton3;
        //private RadioButton radioButton2;
        private RadioButton radMale;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label Country;
        private Label Gender;
        private Label lblName;
        private Label id;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private Button Add;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}