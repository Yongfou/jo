using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading; // Required for this example

namespace ProgressBarExample
{
    public partial class Form1 : Form
    {
        // Flag that indcates if a process is running
        private bool isProcessRunning = false;

        //Auto-generated form constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Simulates a running background process with a quantifiable 
        // indicator of progress, using the progress bar within the 
        // main form
        private void button1_Click(object sender, EventArgs e) 
        {
            // If a process is already running, warn the user and cancel the operation
            if (isProcessRunning) 
            {
                MessageBox.Show("A process is already running.");
                return;
            }

            // Initialize the thread that will handle the background process
            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    // Set the flag that indicates if a process is currently running
                    isProcessRunning = true;

                    // Iterate from 0 - 99
                    // On each iteration, pause the thread for .05 seconds, then update the progress bar
                    for (int n = 0; n < 100; n++ )
                    {
                        Thread.Sleep(50);
                        progressBar1.BeginInvoke(new Action(() => progressBar1.Value = n));
                    }

                    // Show a dialog box that confirms the process has completed
                    MessageBox.Show("Thread completed!");

                    // Reset the progress bar's value if it is still valid to do so
                    if (progressBar1.InvokeRequired)
                        progressBar1.BeginInvoke(new Action(() => progressBar1.Value = 0));

                    // Reset the flag that indicates if a process is currently running
                    isProcessRunning = false;
                }
            ));

            // Start the background process thread
            backgroundThread.Start();
        }

        // Simulates a running background process with a quantifiable 
        // indicator of progress, using a seperate modal dialog containing
        // a progress bar
        private void button2_Click(object sender, EventArgs e)
        {
            // If a process is already running, warn the user and cancel the operation
            if (isProcessRunning)
            {
                MessageBox.Show("A process is already running.");
                return;
            }

            // Initialize the dialog that will contain the progress bar
            ProgressDialog progressDialog = new ProgressDialog();

            // Initialize the thread that will handle the background process
            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    // Set the flag that indicates if a process is currently running
                    isProcessRunning = true;

                    // Iterate from 0 - 99
                    // On each iteration, pause the thread for .05 seconds, then update the dialog's progress bar
                    for (int n = 0; n < 100; n++)
                    {
                        Thread.Sleep(50);
                        progressDialog.UpdateProgress(n);
                    }

                    // Show a dialog box that confirms the process has completed
                    MessageBox.Show("Thread completed!");

                    // Close the dialog if it hasn't been already
                    if (progressDialog.InvokeRequired)
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));

                    // Reset the flag that indicates if a process is currently running
                    isProcessRunning = false;
                }
            ));

            // Start the background process thread
            backgroundThread.Start();

            // Open the dialog
            progressDialog.ShowDialog();
        }

        // Simulates a running background process without a quantifiable 
        // indicator of progress, using a seperate modal dialog containing
        // a progress bar
        private void button3_Click(object sender, EventArgs e)
        {
            // If a process is already running, warn the user and cancel the operation
            if (isProcessRunning)
            {
                MessageBox.Show("A process is already running.");
                return;
            }

            // Initialize the dialog that will contain the progress bar
            ProgressDialog progressDialog = new ProgressDialog();

            // Initialize the thread that will handle the background process
            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    // Set the flag that indicates if a process is currently running
                    isProcessRunning = true;

                    // Set the dialog to operate in indeterminate mode
                    progressDialog.SetIndeterminate(true);

                    // Pause the thread for five seconds
                    Thread.Sleep(5000);

                    // Show a dialog box that confirms the process has completed
                    MessageBox.Show("Thread completed!");

                    // Close the dialog if it hasn't been already
                    if (progressBar1.InvokeRequired)
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));

                    // Reset the flag that indicates if a process is currently running
                    isProcessRunning = false;
                }
            ));

            // Start the background process thread
            backgroundThread.Start();

            // Open the dialog
            progressDialog.ShowDialog();
        }
    }
}
