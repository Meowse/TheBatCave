namespace CodeSamples
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
            this.increment = new System.Windows.Forms.Button();
            this.displayCount = new System.Windows.Forms.Label();
            this.doSomethingSpecial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(13, 13);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(75, 23);
            this.increment.TabIndex = 0;
            this.increment.Text = "Double It!";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // displayCount
            // 
            this.displayCount.AutoSize = true;
            this.displayCount.Location = new System.Drawing.Point(95, 22);
            this.displayCount.Name = "displayCount";
            this.displayCount.Size = new System.Drawing.Size(35, 13);
            this.displayCount.TabIndex = 1;
            this.displayCount.Text = "label1";
            // 
            // doSomethingSpecial
            // 
            this.doSomethingSpecial.Location = new System.Drawing.Point(13, 42);
            this.doSomethingSpecial.Name = "doSomethingSpecial";
            this.doSomethingSpecial.Size = new System.Drawing.Size(75, 23);
            this.doSomethingSpecial.TabIndex = 2;
            this.doSomethingSpecial.Text = "Specialize!";
            this.doSomethingSpecial.UseVisualStyleBackColor = true;
            this.doSomethingSpecial.Click += new System.EventHandler(this.doSomethingSpecial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.doSomethingSpecial);
            this.Controls.Add(this.displayCount);
            this.Controls.Add(this.increment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Label displayCount;
        private System.Windows.Forms.Button doSomethingSpecial;
    }
}

