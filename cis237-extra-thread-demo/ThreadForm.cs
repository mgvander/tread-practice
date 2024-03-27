using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cis237_extra_thread_demo
{
    public partial class ThreadForm : Form
    {
        public ThreadForm()
        {
            InitializeComponent();

        }

        private void ThreadForm_Load(object sender, EventArgs e)
        {

        }

        /********************************************************************************
         * Shared Methods
         * *****************************************************************************/
        private void UpdateProgressBar(int value)
        {
            ProgressBar.Value = value;

        }

        /********************************************************************************
         * Syncronous Way
         * *****************************************************************************/

        private void SubmitSyncButton_Click(object sender, EventArgs e)
        {
            PopulateNameLabel();

        }

        private void PopulateNameLabel()
        {
            string name;

            OutputLabel.Text = "Fetching Name";

            name = GetName();

            OutputLabel.Text = name;
        }

        private string GetName()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);

                UpdateProgressBar((i * 5) + 5);

            }

            return "Michael VanderMyde";

        }

        /********************************************************************************
         * Async Way
         * *****************************************************************************/

        private async void SubmitAsyncButton_Click(object sender, EventArgs e)
        {
            Progress<int> progress = new Progress<int>();

            // Add out ReportProgress method as a handler to the
            // progressChanged event of the progress object.
            progress.ProgressChanged += ReportProgress;

            // Await for the results of the PopulateNameLabelAsync
            await PopulateNameLAbelAsync(progress);

        }

        private void ReportProgress(object sender, int e)
        {
            UpdateProgressBar(e);

        }

        private async Task PopulateNameLAbelAsync(IProgress<int> progress)
        {
            string name;

            OutputLabel.Text = "Fetching Name";

            // Await for the results of the Task.Run.
            // Task.Run expects a Func, in this case we are sending
            // over a lambda expression that just calls the GetNameAsync
            // method that is declared below.
            // This means that the work of GetNameAsync will be executed
            // on a seperate thread.
            name = await Task.Run(() => GetNameAsync(progress));

            OutputLabel.Text = name;

        }

        private string GetNameAsync(IProgress<int> progress)
        {
            for (int i = 0; i < 20; i++)
            {
                // This will NOT be on the U.I. thread. It's on the Task one.
                Thread.Sleep(500);

                // Use progress object to report current progress.
                progress.Report((i * 5) + 5);

            }

            return "Michael VanderMyde";

        }
    }
}
