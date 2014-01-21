namespace SomethingInteresting
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.ClickMe = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "National Geographic kids humor... :)";
            // 
            // AnswerButton
            // 
            this.AnswerButton.BackColor = System.Drawing.Color.Silver;
            this.AnswerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AnswerButton.FlatAppearance.BorderSize = 20;
            this.AnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AnswerButton.Location = new System.Drawing.Point(210, 82);
            this.AnswerButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(263, 64);
            this.AnswerButton.TabIndex = 1;
            this.AnswerButton.Text = "Why did the dolphic cross the ocean?";
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // ClickMe
            // 
            this.ClickMe.AutomaticDelay = 5;
            this.ClickMe.IsBalloon = true;
            this.ClickMe.ShowAlways = true;
            this.ClickMe.Tag = "Click Me";
            this.ClickMe.ToolTipTitle = "Click Me!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(667, 193);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Joke #1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnswerButton;
        public System.Windows.Forms.ToolTip ClickMe;
    }
}

