namespace FizzBuzz
{
    partial class Form1
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
            this.maxValueField = new System.Windows.Forms.TextBox();
            this.fizzBuzzIt = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxValueField
            // 
            this.maxValueField.Location = new System.Drawing.Point(13, 13);
            this.maxValueField.Name = "maxValueField";
            this.maxValueField.Size = new System.Drawing.Size(100, 20);
            this.maxValueField.TabIndex = 0;
            // 
            // fizzBuzzIt
            // 
            this.fizzBuzzIt.Location = new System.Drawing.Point(119, 11);
            this.fizzBuzzIt.Name = "fizzBuzzIt";
            this.fizzBuzzIt.Size = new System.Drawing.Size(75, 23);
            this.fizzBuzzIt.TabIndex = 1;
            this.fizzBuzzIt.Text = "FizzBuzz It!";
            this.fizzBuzzIt.UseVisualStyleBackColor = true;
            this.fizzBuzzIt.Click += new System.EventHandler(this.fizzBuzzIt_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(13, 40);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(13, 104);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "  \r\n  \r\n  \r\n  \r\n  \r\n  \r\n  \r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.fizzBuzzIt);
            this.Controls.Add(this.maxValueField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxValueField;
        private System.Windows.Forms.Button fizzBuzzIt;
        private System.Windows.Forms.Label outputLabel;
    }
}

