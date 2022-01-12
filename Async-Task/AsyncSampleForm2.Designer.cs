
namespace LEARNING_ASYNC_MULTITHREAD_PROGRAMMING.Async_Task
{
    partial class AsyncSampleForm2
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
            this.AsyncButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AsyncButton
            // 
            this.AsyncButton.Location = new System.Drawing.Point(13, 23);
            this.AsyncButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsyncButton.Name = "AsyncButton";
            this.AsyncButton.Size = new System.Drawing.Size(434, 72);
            this.AsyncButton.TabIndex = 3;
            this.AsyncButton.Text = "Async Tasking";
            this.AsyncButton.UseVisualStyleBackColor = true;
            this.AsyncButton.Click += new System.EventHandler(this.AsyncButton_ClickAsync);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(13, 105);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(434, 121);
            this.resultTextBox.TabIndex = 4;
            // 
            // AsyncSampleForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 237);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.AsyncButton);
            this.Name = "AsyncSampleForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsyncSampleForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AsyncButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}