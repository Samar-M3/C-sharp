using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace Winform
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        private List<Users> users = new List<Users>();
        //int nextid = 1;
        int NextID = 1;

        //List<Users> users = new List<Users>();
        private void Userinfo_Load(object sender, EventArgs e)
        {
            //lblName.Text = NextID.ToString();           // NextName -> NextID
            comboBox1.Items.Add("India");
            comboBox1.Items.Add("USA");
            comboBox1.Items.Add("UK");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblName.Text))
            {
                MessageBox.Show("Please enter the Name: ");
                return;
            }
          

            string gender = "";
            if (radMale.Checked)
            {
                gender = "Male";
            }
            else if (radfemale.Checked)
            {
                gender = "Female";
            }
            else if (radother.Checked)
            {
                gender = "Others";
            }
            else
            {
                MessageBox.Show("Please select the Gender: ");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select the Country: ");
                return;
            }

            // Add the user to the list (this must be inside the method)
            //Users user = new Users(lblName.Text, textBox2.Text, comboBox1.SelectedItem.ToString(),);
            //users.Add(user);

            //NextID++;
            lblName.Text = NextID.ToString();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
            Clear();
        }

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            radMale.Checked = false;
            radfemale.Checked = false;
            radother.Checked = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


    }
}
