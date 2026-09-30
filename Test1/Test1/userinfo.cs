using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Test1.User
    ;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class userinfo : Form
    {
        public userinfo()
        {
            InitializeComponent();
        }
        //int NextID = 1;

        //List<Users> users = new List<Users>();
        private void Userinfo_Load(object sender, EventArgs e)
        {
            //lblName.Text = NextID.ToString();           // NextName -> NextID
            cboxCountry.Items.Add("India");
            cboxCountry.Items.Add("USA");
            cboxCountry.Items.Add("UK");
            dgvUserDetails.AutoGenerateColumns = true;
            dgvUserDetails.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the Name: ");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter the Address: ");
                return;
            }

            string gender = "";
            if (rbtnMale.Checked)
            {
                gender = "Male";
            }
            else if (rbtnFemale.Checked)
            {
                gender = "Female";
            }
            else if (rbtnOthers.Checked)
            {
                gender = "Others";
            }
            else
            {
                MessageBox.Show("Please select the Gender: ");
                return;
            }

            if (cboxCountry.SelectedItem == null)
            {
                MessageBox.Show("Please select the Country: ");
                return;
            }

            // Add the user to the list (this must be inside the method)
            Users user = new Users(txtName.Text, txtAddress.Text, cboxCountry.SelectedItem.ToString(), gender);
            users.Add(user);

            //NextID++;
            lblName.Text = NextID.ToString();
            dgvUserDetails.DataSource = null;
            dgvUserDetails.DataSource = users;
            Clear();
        }

        private void Clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            cboxCountry.SelectedIndex = -1;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            rbtnOthers.Checked = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


    }
}