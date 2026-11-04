using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace sumNumbersBackground
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();

            // Hook up the BackgroundWorker events
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
        }

        // Runs on the UI thread when the button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;          // prevent a second run
            lblResult.Text = "Calculating...";
            backgroundWorker1.RunWorkerAsync();    // start background work
        }

        // Runs on a background thread (never touch UI controls here)
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            long sum = 0;                          // long: the total exceeds int range
            for (int i = 1; i <= 100000; i++)
            {
                sum += i;
            }
            e.Result = sum;                        // hand the result back
        }

        // Runs back on the UI thread when DoWork finishes
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCalculate.Enabled = true;

            if (e.Error != null)
            {
                lblResult.Text = "Error occurred.";
                MessageBox.Show(e.Error.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long result = (long)e.Result;
            lblResult.Text = "Sum = " + result.ToString("N0");

            MessageBox.Show("Calculation completed!", "Done",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}