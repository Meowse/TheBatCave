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
            this.fizzDivisorField = new System.Windows.Forms.TextBox();
            this.buzzDivisorField = new System.Windows.Forms.TextBox();
            this.newFizzBuzzerButton = new System.Windows.Forms.Button();
            this.bimDivisorField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maxValueField
            // 
            this.maxValueField.Location = new System.Drawing.Point(233, 66);
            this.maxValueField.Name = "maxValueField";
            this.maxValueField.Size = new System.Drawing.Size(100, 20);
            this.maxValueField.TabIndex = 0;
            // 
            // fizzBuzzIt
            // 
            this.fizzBuzzIt.Location = new System.Drawing.Point(297, 92);
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
            // newFizzBuzzerButton
            // 
            this.newFizzBuzzerButton.Location = new System.Drawing.Point(281, 37);
            this.newFizzBuzzerButton.Name = "newFizzBuzzerButton";
            this.newFizzBuzzerButton.Size = new System.Drawing.Size(116, 23);
            this.newFizzBuzzerButton.TabIndex = 5;
            this.newFizzBuzzerButton.Text = "New FizzBuzzer!";
            this.newFizzBuzzerButton.UseVisualStyleBackColor = true;
            this.newFizzBuzzerButton.Click += new System.EventHandler(this.newFizzBuzzerButton_Click);
            // 
            // bimDivisorField
            // 
            this.bimDivisorField.Location = new System.Drawing.Point(233, 11);
            this.bimDivisorField.Name = "bimDivisorField";
            this.bimDivisorField.Size = new System.Drawing.Size(100, 20);
            this.bimDivisorField.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 495);
            this.Controls.Add(this.bimDivisorField);
            this.Controls.Add(this.newFizzBuzzerButton);
            this.Controls.Add(this.buzzDivisorField);
            this.Controls.Add(this.fizzDivisorField);
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
        private System.Windows.Forms.TextBox fizzDivisorField;
        private System.Windows.Forms.TextBox buzzDivisorField;
        private System.Windows.Forms.Button newFizzBuzzerButton;
        private System.Windows.Forms.TextBox bimDivisorField;
    }
}

