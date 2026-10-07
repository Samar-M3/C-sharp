namespace Week5_ClassTask
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
            Namelbl = new Label();
            Agelbl = new Label();
            Sectionlbl = new Label();
            Addresslbl = new Label();
            Rolllbl = new Label();
            phonelbl = new Label();
            NameBox = new TextBox();
            AgeBox = new TextBox();
            SectionBox = new TextBox();
            AddressBox = new TextBox();
            RollBox = new TextBox();
            PhoneBox = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Updatebtn = new Button();
            Deletebtn = new Button();
            Clear = new Button();
            Refresh = new Button();
            Addbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Location = new Point(66, 15);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(49, 20);
            Namelbl.TabIndex = 0;
            Namelbl.Text = "Name";
            // 
            // Agelbl
            // 
            Agelbl.AutoSize = true;
            Agelbl.Location = new Point(66, 66);
            Agelbl.Name = "Agelbl";
            Agelbl.Size = new Size(36, 20);
            Agelbl.TabIndex = 1;
            Agelbl.Text = "Age";
            // 
            // Sectionlbl
            // 
            Sectionlbl.AutoSize = true;
            Sectionlbl.Location = new Point(57, 115);
            Sectionlbl.Name = "Sectionlbl";
            Sectionlbl.Size = new Size(58, 20);
            Sectionlbl.TabIndex = 2;
            Sectionlbl.Text = "Section";
            // 
            // Addresslbl
            // 
            Addresslbl.AutoSize = true;
            Addresslbl.Location = new Point(57, 166);
            Addresslbl.Name = "Addresslbl";
            Addresslbl.Size = new Size(62, 20);
            Addresslbl.TabIndex = 3;
            Addresslbl.Text = "Address";
            // 
            // Rolllbl
            // 
            Rolllbl.AutoSize = true;
            Rolllbl.Location = new Point(46, 211);
            Rolllbl.Name = "Rolllbl";
            Rolllbl.Size = new Size(90, 20);
            Rolllbl.TabIndex = 4;
            Rolllbl.Text = "Roll number";
            // 
            // phonelbl
            // 
            phonelbl.AutoSize = true;
            phonelbl.Location = new Point(28, 262);
            phonelbl.Name = "phonelbl";
            phonelbl.Size = new Size(108, 20);
            phonelbl.TabIndex = 5;
            phonelbl.Text = "Phone Number";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(147, 12);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 6;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(147, 63);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(125, 27);
            AgeBox.TabIndex = 7;
            // 
            // SectionBox
            // 
            SectionBox.Location = new Point(147, 112);
            SectionBox.Name = "SectionBox";
            SectionBox.Size = new Size(125, 27);
            SectionBox.TabIndex = 8;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(147, 163);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(125, 27);
            AddressBox.TabIndex = 9;
            // 
            // RollBox
            // 
            RollBox.Location = new Point(147, 211);
            RollBox.Name = "RollBox";
            RollBox.Size = new Size(125, 27);
            RollBox.TabIndex = 10;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(147, 255);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(125, 27);
            PhoneBox.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(474, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 442);
            panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(167, 336);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(94, 29);
            Updatebtn.TabIndex = 14;
            Updatebtn.Text = "Update Student";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(299, 343);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(94, 29);
            Deletebtn.TabIndex = 15;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(45, 389);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 16;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(196, 399);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(94, 29);
            Refresh.TabIndex = 17;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(28, 336);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(94, 29);
            Addbtn.TabIndex = 18;
            Addbtn.Text = "Add Student";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Addbtn);
            Controls.Add(Refresh);
            Controls.Add(Clear);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(panel1);
            Controls.Add(PhoneBox);
            Controls.Add(RollBox);
            Controls.Add(AddressBox);
            Controls.Add(SectionBox);
            Controls.Add(AgeBox);
            Controls.Add(NameBox);
            Controls.Add(phonelbl);
            Controls.Add(Rolllbl);
            Controls.Add(Addresslbl);
            Controls.Add(Sectionlbl);
            Controls.Add(Agelbl);
            Controls.Add(Namelbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Namelbl;
        private Label Agelbl;
        private Label Sectionlbl;
        private Label Addresslbl;
        private Label Rolllbl;
        private Label phonelbl;
        private TextBox NameBox;
        private TextBox AgeBox;
        private TextBox SectionBox;
        private TextBox AddressBox;
        private TextBox RollBox;
        private TextBox PhoneBox;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button Updatebtn;
        private Button Deletebtn;
        private Button Clear;
        private Button Refresh;
        private Button Addbtn;
    }
}
