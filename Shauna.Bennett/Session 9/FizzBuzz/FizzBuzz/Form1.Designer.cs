namespace FizzBuzzBim
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
            this.fizzBuzzBimIt = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.fizzDivisorField = new System.Windows.Forms.TextBox();
            this.buzzDivisorField = new System.Windows.Forms.TextBox();
            this.newFizzBuzzBimmerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxValueField
            // 
            this.maxValueField.Location = new System.Drawing.Point(12, 37);
            this.maxValueField.Name = "maxValueField";
            this.maxValueField.Size = new System.Drawing.Size(100, 20);
            this.maxValueField.TabIndex = 0;
            // 
            // fizzBuzzBimIt
            // 
            this.fizzBuzzBimIt.Location = new System.Drawing.Point(118, 35);
            this.fizzBuzzBimIt.Name = "fizzBuzzBimIt";
            this.fizzBuzzBimIt.Size = new System.Drawing.Size(90, 22);
            this.fizzBuzzBimIt.TabIndex = 1;
            this.fizzBuzzBimIt.Text = "FizzBuzzBim It!";
            this.fizzBuzzBimIt.UseVisualStyleBackColor = true;
            this.fizzBuzzBimIt.Click += new System.EventHandler(this.fizzBuzzIt_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 60);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(13, 104);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "  \r\n  \r\n  \r\n  \r\n  \r\n  \r\n  \r\n\r\n";
            // 
            // fizzDivisorField
            // 
            this.fizzDivisorField.Location = new System.Drawing.Point(12, 11);
            this.fizzDivisorField.Name = "fizzDivisorField";
            this.fizzDivisorField.Size = new System.Drawing.Size(100, 20);
            this.fizzDivisorField.TabIndex = 3;
            // 
            // buzzDivisorField
            // 
            this.buzzDivisorField.Location = new System.Drawing.Point(118, 11);
            this.buzzDivisorField.Name = "buzzDivisorField";
            this.buzzDivisorField.Size = new System.Drawing.Size(100, 20);
            this.buzzDivisorField.TabIndex = 4;
            // 
            // newFizzBuzzBimmerButton
            // 
            this.newFizzBuzzBimmerButton.Location = new System.Drawing.Point(224, 9);
            this.newFizzBuzzBimmerButton.Name = "newFizzBuzzBimmerButton";
            this.newFizzBuzzBimmerButton.Size = new System.Drawing.Size(143, 22);
            this.newFizzBuzzBimmerButton.TabIndex = 5;
            this.newFizzBuzzBimmerButton.Text = "New FizzBuzzBimmer!";
            this.newFizzBuzzBimmerButton.UseVisualStyleBackColor = true;
            this.newFizzBuzzBimmerButton.Click += new System.EventHandler(this.newFizzBuzzerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 495);
            this.Controls.Add(this.newFizzBuzzBimmerButton);
            this.Controls.Add(this.buzzDivisorField);
            this.Controls.Add(this.fizzDivisorField);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.fizzBuzzBimIt);
            this.Controls.Add(this.maxValueField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxValueField;
        private System.Windows.Forms.Button fizzBuzzBimIt;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox fizzDivisorField;
        private System.Windows.Forms.TextBox buzzDivisorField;
        private System.Windows.Forms.Button newFizzBuzzBimmerButton;
    }
}

