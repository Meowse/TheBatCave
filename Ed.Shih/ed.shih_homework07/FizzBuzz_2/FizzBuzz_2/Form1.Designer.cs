namespace FizzBuzz_2
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
            this.MaxValue = new System.Windows.Forms.TextBox();
            this.FizzBuzz = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaxValue
            // 
            this.MaxValue.Location = new System.Drawing.Point(31, 27);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(100, 22);
            this.MaxValue.TabIndex = 0;
            this.MaxValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FizzBuzz
            // 
            this.FizzBuzz.Location = new System.Drawing.Point(159, 26);
            this.FizzBuzz.Name = "FizzBuzz";
            this.FizzBuzz.Size = new System.Drawing.Size(75, 23);
            this.FizzBuzz.TabIndex = 1;
            this.FizzBuzz.Text = "FizzBuzz Me!";
            this.FizzBuzz.UseVisualStyleBackColor = true;
            this.FizzBuzz.Click += new System.EventHandler(this.FizzButton1Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(31, 68);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(8, 493);
            this.output.TabIndex = 2;
            this.output.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 406);
            this.Controls.Add(this.output);
            this.Controls.Add(this.FizzBuzz);
            this.Controls.Add(this.MaxValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaxValue;
        private System.Windows.Forms.Button FizzBuzz;
        private System.Windows.Forms.Label output;
    }
}

