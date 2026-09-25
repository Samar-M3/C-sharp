namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = num1 + num2;
            MessageBox.Show($"Result: {result}");
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = num1 - num2;
            MessageBox.Show($"Result: {result}");
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = num1 * num2;
            MessageBox.Show($"Result: {result}");
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            if (num2 != 0)
            {
                double result = num1 / num2;
                MessageBox.Show($"Result: {result}");
            }
            else
            {
                MessageBox.Show("Error: Division by zero is not allowed.");
            }
        }
    }
}
