namespace Class_task
{
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
           x++;
            counter.Text = x.ToString();
        }
    }
}
