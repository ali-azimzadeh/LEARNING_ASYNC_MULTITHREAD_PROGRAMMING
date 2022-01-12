
namespace LEARNING_ASYNC_MULTITHREAD_PROGRAMMING.Async_Task
{
    partial class AsyncSampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.AsyncButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(24, 108);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(637, 444);
            this.resultTextBox.TabIndex = 3;
            // 
            // AsyncButton
            // 
            this.AsyncButton.Location = new System.Drawing.Point(24, 10);
            this.AsyncButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsyncButton.Name = "AsyncButton";
            this.AsyncButton.Size = new System.Drawing.Size(638, 72);
            this.AsyncButton.TabIndex = 2;
            this.AsyncButton.Text = "Async Tasking";
            this.AsyncButton.UseVisualStyleBackColor = true;
            this.AsyncButton.Click += new System.EventHandler(this.AsyncButton_ClickAsync);
            // 
            // AsyncSampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 562);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.AsyncButton);
            this.Name = "AsyncSampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsyncSampleForm";
            this.Load += new System.EventHandler(this.AsyncSampleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button AsyncButton;
    }
}