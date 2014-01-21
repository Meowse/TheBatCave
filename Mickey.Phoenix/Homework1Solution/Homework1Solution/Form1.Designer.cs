namespace Homework1Solution
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
            this.learnBetterLink = new System.Windows.Forms.Label();
            this.doSomething = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // learnBetterLink
            // 
            this.learnBetterLink.AutoSize = true;
            this.learnBetterLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnBetterLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.learnBetterLink.Location = new System.Drawing.Point(13, 13);
            this.learnBetterLink.Name = "learnBetterLink";
            this.learnBetterLink.Size = new System.Drawing.Size(407, 20);
            this.learnBetterLink.TabIndex = 0;
            this.learnBetterLink.Text = "...because doing homework helps me learn better.";
            this.learnBetterLink.Click += new System.EventHandler(this.learnBetterLink_Click);
            // 
            // doSomething
            // 
            this.doSomething.Location = new System.Drawing.Point(17, 46);
            this.doSomething.Name = "doSomething";
            this.doSomething.Size = new System.Drawing.Size(403, 23);
            this.doSomething.TabIndex = 1;
            this.doSomething.Text = "I can respond to a button click!";
            this.doSomething.UseVisualStyleBackColor = true;
            this.doSomething.Click += new System.EventHandler(this.doSomething_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 94);
            this.Controls.Add(this.doSomething);
            this.Controls.Add(this.learnBetterLink);
            this.Name = "Form1";
            this.Text = "I love doing homework...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label learnBetterLink;
        private System.Windows.Forms.Button doSomething;
    }
}

