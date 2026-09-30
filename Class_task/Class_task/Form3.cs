using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Class_task
{
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void percentbtn_Click(object sender, EventArgs e)
        {
            output.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text) *100).ToString()+"%";
            output.Visible = true;
        }
    }
}
