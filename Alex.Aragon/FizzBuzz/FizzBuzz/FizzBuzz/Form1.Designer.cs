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
            this.fizzbuzzbtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.input_txt = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fizzbuzzbtn
            // 
            this.fizzbuzzbtn.Location = new System.Drawing.Point(259, 66);
            this.fizzbuzzbtn.Name = "fizzbuzzbtn";
            this.fizzbuzzbtn.Size = new System.Drawing.Size(75, 23);
            this.fizzbuzzbtn.TabIndex = 1;
            this.fizzbuzzbtn.Text = "Get buzzed!";
            this.fizzbuzzbtn.UseVisualStyleBackColor = true;
            this.fizzbuzzbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(31, 12);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(192, 325);
            this.output.TabIndex = 2;
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(259, 40);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(100, 20);
            this.input_txt.TabIndex = 3;
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Location = new System.Drawing.Point(259, 21);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(70, 13);
            this.input.TabIndex = 4;
            this.input.Text = "Enter number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 361);
            this.Controls.Add(this.input);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.output);
            this.Controls.Add(this.fizzbuzzbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fizzbuzzbtn;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.Label input;
    }
}

