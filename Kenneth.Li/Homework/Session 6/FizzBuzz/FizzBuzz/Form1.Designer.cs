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
            this.maxValueTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayNumberTextbox = new System.Windows.Forms.TextBox();
            this.displayNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxValueTextbox
            // 
            this.maxValueTextbox.Location = new System.Drawing.Point(101, 384);
            this.maxValueTextbox.Name = "maxValueTextbox";
            this.maxValueTextbox.Size = new System.Drawing.Size(44, 20);
            this.maxValueTextbox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Maximum Value:";
            // 
            // displayNumberTextbox
            // 
            this.displayNumberTextbox.Location = new System.Drawing.Point(23, 12);
            this.displayNumberTextbox.Multiline = true;
            this.displayNumberTextbox.Name = "displayNumberTextbox";
            this.displayNumberTextbox.Size = new System.Drawing.Size(217, 336);
            this.displayNumberTextbox.TabIndex = 7;
            // 
            // displayNumbers
            // 
            this.displayNumbers.Location = new System.Drawing.Point(23, 410);
            this.displayNumbers.Name = "displayNumbers";
            this.displayNumbers.Size = new System.Drawing.Size(217, 29);
            this.displayNumbers.TabIndex = 6;
            this.displayNumbers.Text = "Display Numbers";
            this.displayNumbers.UseVisualStyleBackColor = true;
            this.displayNumbers.Click += new System.EventHandler(this.displayNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 451);
            this.Controls.Add(this.maxValueTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayNumberTextbox);
            this.Controls.Add(this.displayNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxValueTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox displayNumberTextbox;
        private System.Windows.Forms.Button displayNumbers;
    }
}

