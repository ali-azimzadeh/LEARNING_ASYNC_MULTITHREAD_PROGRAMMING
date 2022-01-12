
namespace LEARNING_ASYNC_MULTITHREAD_PROGRAMMING.MultiThread
{
    partial class MultiThreadForm1
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
            this.MultiThreadButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MultiThreadButton
            // 
            this.MultiThreadButton.Location = new System.Drawing.Point(27, 25);
            this.MultiThreadButton.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.MultiThreadButton.Name = "MultiThreadButton";
            this.MultiThreadButton.Size = new System.Drawing.Size(637, 94);
            this.MultiThreadButton.TabIndex = 1;
            this.MultiThreadButton.Text = "Multhreading";
            this.MultiThreadButton.UseVisualStyleBackColor = true;
            this.MultiThreadButton.Click += new System.EventHandler(this.MultiThreadButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(27, 133);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(637, 272);
            this.resultTextBox.TabIndex = 2;
            // 
            // MultiThreadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 419);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.MultiThreadButton);
            this.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MultiThreadForm1";
            this.Text = "MultiThreadForm1";
            this.Load += new System.EventHandler(this.MultiThreadForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MultiThreadButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}