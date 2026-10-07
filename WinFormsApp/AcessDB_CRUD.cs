using System.Data;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;

namespace SectionC_WindowsForms
{
    public partial class AccessDB_CRUD : Form
    {
        string sqlconnectionstring = @"Data Source=LAPTOP-MKR1T4D3;Initial Catalog=demo1; Persist Security Info=True;User ID=Samar;Password=samar1234;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""SQL Server Management Studio"";Command Timeout=0";
        int rowSelectedIndex = 0;
        public AccessDB_CRUD()
        {
            InitializeComponent();
        }

        private void TestConnection()
        {
            SqlConnection sqlconnection = new SqlConnection(sqlconnectionstring);
            sqlconnection.Open();
            sqlconnection.Close();

        }

        private void AccessDB_Load(object sender, EventArgs e)
        {
            DataLoadFromDB();
        }

        private void DataLoadFromDB()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(sqlconnectionstring);
                string query = "SELECT * FROM Books";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewBooks.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string title = textBoxTitle.Text;
                string publisher = textBoxPublisher.Text;
                int pages = int.Parse(textBoxPages.Text);

                SqlConnection sqlConnection = new SqlConnection(sqlconnectionstring);
                string query = "INSERT INTO Books (Title, Publisher, Pages) VALUES (@Title, @Publisher, @Pages)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Title", title);
                sqlCommand.Parameters.AddWithValue("@Publisher", publisher);
                sqlCommand.Parameters.AddWithValue("@Pages", pages);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Record inserted successfully.");
                DataLoadFromDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowSelectedIndex >= 0)
                {
                    SqlConnection sqlConnection = new SqlConnection(sqlconnectionstring);
                    string query = "DELETE FROM Books WHERE ID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@ID", dataGridViewBooks.Rows[rowSelectedIndex].Cells["ID"].Value);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Record deleted successfully.");
                    DataLoadFromDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
        }

        private void dataGridViewBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBooks.SelectedRows[0];
                textBoxTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                textBoxPublisher.Text = selectedRow.Cells["Publisher"].Value.ToString();
                textBoxPages.Text = selectedRow.Cells["Pages"].Value.ToString();
            }
        }
    }
}
