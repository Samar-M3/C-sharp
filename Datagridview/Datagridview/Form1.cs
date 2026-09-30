using System.Net;
using System.Xml.Linq;

namespace Datagridview
{
    public partial class Form1 : Form
    {
        int id = 1;
        public Form1()
        {
            InitializeComponent();

            // Create columns
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Country", "Country");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Get values from controls
            string name = namebox.Text;
            string address = textBox3.Text;
            string email = textBox4.Text;
            string country = comboBox1.Text;

            // Add data to DataGridView
            dataGridView1.Rows.Add(
                name,
                address,
                email,
                country
            );


            // Clear the input fields
            namebox.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}