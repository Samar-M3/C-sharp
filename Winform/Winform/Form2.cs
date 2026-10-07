namespace Winform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form1_Tick(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Updatetime;
            timer1.Start();
        }

        private void Updatetime(object sender, EventArgs e)
        {
            lblUtcTime.Text = DateTime.UtcNow.ToString("HH:mm:ss");
            lblTime.Text = DateTime.UtcNow.ToString("HH:mm:ss");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
