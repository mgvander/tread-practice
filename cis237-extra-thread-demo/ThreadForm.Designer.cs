
namespace cis237_extra_thread_demo
{
    partial class ThreadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OutputLabel = new System.Windows.Forms.Label();
            ProgressBar = new System.Windows.Forms.ProgressBar();
            SubmitSyncButton = new System.Windows.Forms.Button();
            SubmitAsyncButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            OutputLabel.Location = new System.Drawing.Point(81, 47);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new System.Drawing.Size(183, 31);
            OutputLabel.TabIndex = 0;
            OutputLabel.Text = "Not Fetched Yet!";
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new System.Drawing.Point(81, 81);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new System.Drawing.Size(183, 29);
            ProgressBar.TabIndex = 1;
            // 
            // SubmitSyncButton
            // 
            SubmitSyncButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SubmitSyncButton.Location = new System.Drawing.Point(81, 129);
            SubmitSyncButton.Name = "SubmitSyncButton";
            SubmitSyncButton.Size = new System.Drawing.Size(183, 42);
            SubmitSyncButton.TabIndex = 2;
            SubmitSyncButton.Text = "Submit Sync";
            SubmitSyncButton.UseVisualStyleBackColor = true;
            SubmitSyncButton.Click += SubmitSyncButton_Click;
            // 
            // SubmitAsyncButton
            // 
            SubmitAsyncButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SubmitAsyncButton.Location = new System.Drawing.Point(81, 177);
            SubmitAsyncButton.Name = "SubmitAsyncButton";
            SubmitAsyncButton.Size = new System.Drawing.Size(183, 42);
            SubmitAsyncButton.TabIndex = 3;
            SubmitAsyncButton.Text = "Submit Async";
            SubmitAsyncButton.UseVisualStyleBackColor = true;
            SubmitAsyncButton.Click += SubmitAsyncButton_Click;
            // 
            // ThreadForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(349, 315);
            Controls.Add(SubmitAsyncButton);
            Controls.Add(SubmitSyncButton);
            Controls.Add(ProgressBar);
            Controls.Add(OutputLabel);
            Name = "ThreadForm";
            Text = "Sync Vs Async";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button SubmitSyncButton;
        private System.Windows.Forms.Button SubmitAsyncButton;
    }
}

