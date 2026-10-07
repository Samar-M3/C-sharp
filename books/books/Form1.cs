using System.Data;
using System.Data.OleDb;

namespace books
{
    public partial class Form1 : Form
    {
        // Database connection
        string connectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=BookCSharp.accdb;";
        string selectedBookKey;
        string selectedTitle;

        public Form1()
        {
            InitializeComponent();
        }

        // DISPLAY RECORDS
        private void Display_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string query = "SELECT BookKey, Title, Pages FROM Books";

            OleDbConnection conn =
                new OleDbConnection(connectionString);

            OleDbDataAdapter adapter =
                new OleDbDataAdapter(query, conn);

            adapter.Fill(ds);

            listBox1.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string bookKey = row["BookKey"].ToString();
                string title = row["Title"].ToString();
                string pages = row["Pages"].ToString();

                listBox1.Items.Add(
                    bookKey + " " + title + " (" + pages + ")"
                );
            }
        }


        // INSERT RECORD
        private void insert_Click(object sender, EventArgs e)
        {
            string bookKey = textBox1.Text;
            string title = textBox2.Text;
            string pages = textBox3.Text;

            string query =
                "INSERT INTO Books (BookKey, Title, Pages) " +
                "VALUES (?, ?, ?)";

            OleDbConnection oleDbConnection =
                new OleDbConnection(connectionString);

            OleDbCommand oleDbCommand =
                new OleDbCommand(query, oleDbConnection);


            oleDbCommand.Parameters.AddWithValue("@BookKey", bookKey);
            oleDbCommand.Parameters.AddWithValue("@Title", title);
            oleDbCommand.Parameters.AddWithValue("@Pages", pages);

            try
            {
                oleDbConnection.Open();

                oleDbCommand.ExecuteNonQuery();

                MessageBox.Show("Record inserted successfully");

                // Clear textboxes
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                // Display updated records
                Display_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message
                );
            }
            finally
            {
                oleDbConnection.Close();
            }
        }

        // EXIT
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditTitle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Books SET [Title] = ? WHERE [BookKey] = ?";

            OleDbConnection conn =
                new OleDbConnection(connectionString);

            OleDbCommand cmd =
                new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@Title", textBox4.Text);
            cmd.Parameters.AddWithValue("@BookKey", selectedBookKey);

            try
            {
                conn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully");

                textBox4.Clear();

                Display_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}