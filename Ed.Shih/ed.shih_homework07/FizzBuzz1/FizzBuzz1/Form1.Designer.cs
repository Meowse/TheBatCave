namespace FizzBuzz1
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
            this.InputExplain = new System.Windows.Forms.Label();
            this.FizzBuzzOutput = new System.Windows.Forms.Label();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.FizzButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputExplain
            // 
            this.InputExplain.AutoSize = true;
            this.InputExplain.Location = new System.Drawing.Point(12, 44);
            this.InputExplain.Name = "InputExplain";
            this.InputExplain.Size = new System.Drawing.Size(262, 17);
            this.InputExplain.TabIndex = 0;
            this.InputExplain.Text = "What Number Should FizzBuzz Run To?";
            // 
            // FizzBuzzOutput
            // 
            this.FizzBuzzOutput.AutoSize = true;
            this.FizzBuzzOutput.Location = new System.Drawing.Point(114, 161);
            this.FizzBuzzOutput.Name = "FizzBuzzOutput";
            this.FizzBuzzOutput.Size = new System.Drawing.Size(0, 17);
            this.FizzBuzzOutput.TabIndex = 1;
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(98, 80);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(100, 22);
            this.Input1.TabIndex = 2;
            this.Input1.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // FizzButton1
            // 
            this.FizzButton1.Location = new System.Drawing.Point(70, 108);
            this.FizzButton1.Name = "FizzButton1";
            this.FizzButton1.Size = new System.Drawing.Size(152, 23);
            this.FizzButton1.TabIndex = 3;
            this.FizzButton1.Text = "Calculate FizzBuzz";
            this.FizzButton1.UseVisualStyleBackColor = true;
            this.FizzButton1.Click += new System.EventHandler(this.FizzButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.FizzButton1);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.FizzBuzzOutput);
            this.Controls.Add(this.InputExplain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputExplain;
        private System.Windows.Forms.Label FizzBuzzOutput;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.Button FizzButton1;
    }
}

