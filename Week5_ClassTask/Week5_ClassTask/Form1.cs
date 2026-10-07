using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week5_ClassTask
{
    public partial class Form1 : Form
    {
        int selectedID;
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
Data Source=D:\L5 SEM_3_2026\Desktop Application Development\Task\Week5_ClassTask\Week5_ClassTask\bin\StudentDB.accdb";
        OleDbConnection con;

        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(connectionString);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            try
            {
                con.Open();
                MessageBox.Show("Database Connected Successfully!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString)) 
                {

                    string query = @"INSERT INTO Student ([Name], [Age], [Section], [Address], [Roll_Number], [Phone_Number]) VALUES (?, ?, ?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    cmd.Parameters.AddWithValue("?", NameBox.Text);
                    cmd.Parameters.AddWithValue("?", AgeBox.Text);
                    cmd.Parameters.AddWithValue("?", SectionBox.Text);
                    cmd.Parameters.AddWithValue("?", AddressBox.Text);
                    cmd.Parameters.AddWithValue("?", RollBox.Text);
                    cmd.Parameters.AddWithValue("?", PhoneBox.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Added Successfully!");
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadData()
        {
            OleDbConnection con = new OleDbConnection(connectionString);

            string query = "SELECT * FROM Student";

            OleDbDataAdapter da = new OleDbDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            OleDbConnection con = new OleDbConnection(connectionString);

            try
            {
                con.Open();

                string query = "UPDATE Student SET [Name] = ?, [Age] = ?, [Section] = ?, [Roll_Number] = ?, [Address] = ?, [Phone_Number] = ? WHERE [ID] = ?";

                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", NameBox.Text);
                cmd.Parameters.AddWithValue("?", AgeBox.Text);
                cmd.Parameters.AddWithValue("?", SectionBox.Text);
                cmd.Parameters.AddWithValue("?", RollBox.Text);
                cmd.Parameters.AddWithValue("?", AddressBox.Text);
                cmd.Parameters.AddWithValue("?", PhoneBox.Text);
                cmd.Parameters.AddWithValue("?", selectedID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record Updated Successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("No record found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedID = Convert.ToInt32(
                dataGridView1.Rows[e.RowIndex].Cells["ID"].Value
            );

            NameBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            RollBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Roll_Number"].Value.ToString();
            SectionBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            AgeBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].Value.ToString();
            AddressBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            PhoneBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone_Number"].Value.ToString();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                OleDbConnection con = new OleDbConnection(connectionString);

                try
                {
                    con.Open();

                    string query = "DELETE FROM Student WHERE [ID] = ?";

                    OleDbCommand cmd = new OleDbCommand(query, con);

                    cmd.Parameters.AddWithValue("?", selectedID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully!");

                        LoadData();

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Record not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearFields()
        {
            NameBox.Clear();
            AgeBox.Clear();
            SectionBox.Clear();
            AddressBox.Clear();
            RollBox.Clear();
            PhoneBox.Clear();

            selectedID = 0;
        }


        private bool ValidateInputs()
        {
            if (NameBox.Text == "")
            {
                MessageBox.Show("Please enter Name.");
                return false;
            }

            if (RollBox.Text == "")
            {
                MessageBox.Show("Please enter Roll Number.");
                return false;
            }

            if (SectionBox.Text == "")
            {
                MessageBox.Show("Please enter Section.");
                return false;
            }

            if (AgeBox.Text == "" || !int.TryParse(AgeBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid Age.");
                return false;
            }

            if (AddressBox.Text == "")
            {
                MessageBox.Show("Please enter Address.");
                return false;
            }

            if (PhoneBox.Text == "")
            {
                MessageBox.Show("Please enter Phone Number.");
                return false;
            }

            return true;
        }
       
    }
}
