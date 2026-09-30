using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Class_task
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "1234")
            {
                output.Text = "Login Successful";

            }
            else
            {
                output.Text = "Invalid Username or Password";
            }
        }
    }
}
