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
            this.NewCalc = new System.Windows.Forms.Button();
            this.fizzDivField = new System.Windows.Forms.TextBox();
            this.buzzDivField = new System.Windows.Forms.TextBox();
            this.bimDivField = new System.Windows.Forms.TextBox();
            this.EnterMaxVal = new System.Windows.Forms.Label();
            this.FizzVal = new System.Windows.Forms.Label();
            this.BuzzVal = new System.Windows.Forms.Label();
            this.BimVal = new System.Windows.Forms.Label();
            this.CalcReminder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaxValue
            // 
            this.MaxValue.Location = new System.Drawing.Point(12, 92);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(100, 22);
            this.MaxValue.TabIndex = 5;
            this.MaxValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FizzBuzz
            // 
            this.FizzBuzz.Location = new System.Drawing.Point(134, 91);
            this.FizzBuzz.Name = "FizzBuzz";
            this.FizzBuzz.Size = new System.Drawing.Size(110, 23);
            this.FizzBuzz.TabIndex = 6;
            this.FizzBuzz.Text = "FizzBuzzBim!";
            this.FizzBuzz.UseVisualStyleBackColor = true;
            this.FizzBuzz.Click += new System.EventHandler(this.FizzButton1Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(24, 131);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(8, 493);
            this.output.TabIndex = 7;
            this.output.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // NewCalc
            // 
            this.NewCalc.Location = new System.Drawing.Point(351, 37);
            this.NewCalc.Name = "NewCalc";
            this.NewCalc.Size = new System.Drawing.Size(110, 23);
            this.NewCalc.TabIndex = 4;
            this.NewCalc.Text = "New Calculator";
            this.NewCalc.UseVisualStyleBackColor = true;
            this.NewCalc.Click += new System.EventHandler(this.NewCalc_Click);
            // 
            // fizzDivField
            // 
            this.fizzDivField.Location = new System.Drawing.Point(12, 38);
            this.fizzDivField.Name = "fizzDivField";
            this.fizzDivField.Size = new System.Drawing.Size(100, 22);
            this.fizzDivField.TabIndex = 1;
            // 
            // buzzDivField
            // 
            this.buzzDivField.Location = new System.Drawing.Point(118, 38);
            this.buzzDivField.Name = "buzzDivField";
            this.buzzDivField.Size = new System.Drawing.Size(100, 22);
            this.buzzDivField.TabIndex = 2;
            // 
            // bimDivField
            // 
            this.bimDivField.Location = new System.Drawing.Point(224, 38);
            this.bimDivField.Name = "bimDivField";
            this.bimDivField.Size = new System.Drawing.Size(100, 22);
            this.bimDivField.TabIndex = 3;
            // 
            // EnterMaxVal
            // 
            this.EnterMaxVal.AutoSize = true;
            this.EnterMaxVal.Location = new System.Drawing.Point(12, 72);
            this.EnterMaxVal.Name = "EnterMaxVal";
            this.EnterMaxVal.Size = new System.Drawing.Size(73, 17);
            this.EnterMaxVal.TabIndex = 7;
            this.EnterMaxVal.Text = "Max Value";
            // 
            // FizzVal
            // 
            this.FizzVal.AutoSize = true;
            this.FizzVal.Location = new System.Drawing.Point(12, 9);
            this.FizzVal.Name = "FizzVal";
            this.FizzVal.Size = new System.Drawing.Size(73, 17);
            this.FizzVal.TabIndex = 8;
            this.FizzVal.Text = "Fizz Value";
            // 
            // BuzzVal
            // 
            this.BuzzVal.AutoSize = true;
            this.BuzzVal.Location = new System.Drawing.Point(115, 9);
            this.BuzzVal.Name = "BuzzVal";
            this.BuzzVal.Size = new System.Drawing.Size(79, 17);
            this.BuzzVal.TabIndex = 9;
            this.BuzzVal.Text = "Buzz Value";
            // 
            // BimVal
            // 
            this.BimVal.AutoSize = true;
            this.BimVal.Location = new System.Drawing.Point(221, 9);
            this.BimVal.Name = "BimVal";
            this.BimVal.Size = new System.Drawing.Size(71, 17);
            this.BimVal.TabIndex = 10;
            this.BimVal.Text = "Bim Value";
            // 
            // CalcReminder
            // 
            this.CalcReminder.AutoSize = true;
            this.CalcReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcReminder.Location = new System.Drawing.Point(348, 72);
            this.CalcReminder.Name = "CalcReminder";
            this.CalcReminder.Size = new System.Drawing.Size(121, 39);
            this.CalcReminder.TabIndex = 11;
            this.CalcReminder.Text = "Remember To Press This\r\nAfter New FizzBuzzBim\r\nValues Are Entered";
            this.CalcReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(500, 846);
            this.Controls.Add(this.CalcReminder);
            this.Controls.Add(this.BimVal);
            this.Controls.Add(this.BuzzVal);
            this.Controls.Add(this.FizzVal);
            this.Controls.Add(this.EnterMaxVal);
            this.Controls.Add(this.bimDivField);
            this.Controls.Add(this.buzzDivField);
            this.Controls.Add(this.fizzDivField);
            this.Controls.Add(this.NewCalc);
            this.Controls.Add(this.output);
            this.Controls.Add(this.FizzBuzz);
            this.Controls.Add(this.MaxValue);
            this.Name = "Form1";
            this.Text = "FizzBuzzBim Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaxValue;
        private System.Windows.Forms.Button FizzBuzz;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button NewCalc;
        private System.Windows.Forms.TextBox fizzDivField;
        private System.Windows.Forms.TextBox buzzDivField;
        private System.Windows.Forms.TextBox bimDivField;
        private System.Windows.Forms.Label EnterMaxVal;
        private System.Windows.Forms.Label FizzVal;
        private System.Windows.Forms.Label BuzzVal;
        private System.Windows.Forms.Label BimVal;
        private System.Windows.Forms.Label CalcReminder;
    }
}

