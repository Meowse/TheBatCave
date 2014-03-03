namespace LightSwitchApp
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
            this.dimmer5 = new System.Windows.Forms.RadioButton();
            this.dimmer4 = new System.Windows.Forms.RadioButton();
            this.dimmer3 = new System.Windows.Forms.RadioButton();
            this.dimmer2 = new System.Windows.Forms.RadioButton();
            this.dimmer1 = new System.Windows.Forms.RadioButton();
            this.dimmer0 = new System.Windows.Forms.RadioButton();
            this.bigButton = new System.Windows.Forms.Button();
            this.dimmerUpButton = new System.Windows.Forms.Button();
            this.dimmerDownButton = new System.Windows.Forms.Button();
            this.lightBrightnessDisplay = new System.Windows.Forms.Label();
            this.bigButtonDoubleClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dimmer5
            // 
            this.dimmer5.AutoSize = true;
            this.dimmer5.Location = new System.Drawing.Point(13, 42);
            this.dimmer5.Name = "dimmer5";
            this.dimmer5.Size = new System.Drawing.Size(14, 13);
            this.dimmer5.TabIndex = 0;
            this.dimmer5.TabStop = true;
            this.dimmer5.UseVisualStyleBackColor = true;
            // 
            // dimmer4
            // 
            this.dimmer4.AutoSize = true;
            this.dimmer4.Location = new System.Drawing.Point(13, 61);
            this.dimmer4.Name = "dimmer4";
            this.dimmer4.Size = new System.Drawing.Size(14, 13);
            this.dimmer4.TabIndex = 1;
            this.dimmer4.TabStop = true;
            this.dimmer4.UseVisualStyleBackColor = true;
            // 
            // dimmer3
            // 
            this.dimmer3.AutoSize = true;
            this.dimmer3.Location = new System.Drawing.Point(13, 80);
            this.dimmer3.Name = "dimmer3";
            this.dimmer3.Size = new System.Drawing.Size(14, 13);
            this.dimmer3.TabIndex = 2;
            this.dimmer3.TabStop = true;
            this.dimmer3.UseVisualStyleBackColor = true;
            // 
            // dimmer2
            // 
            this.dimmer2.AutoSize = true;
            this.dimmer2.Location = new System.Drawing.Point(13, 99);
            this.dimmer2.Name = "dimmer2";
            this.dimmer2.Size = new System.Drawing.Size(14, 13);
            this.dimmer2.TabIndex = 3;
            this.dimmer2.TabStop = true;
            this.dimmer2.UseVisualStyleBackColor = true;
            // 
            // dimmer1
            // 
            this.dimmer1.AutoSize = true;
            this.dimmer1.Location = new System.Drawing.Point(13, 118);
            this.dimmer1.Name = "dimmer1";
            this.dimmer1.Size = new System.Drawing.Size(14, 13);
            this.dimmer1.TabIndex = 4;
            this.dimmer1.TabStop = true;
            this.dimmer1.UseVisualStyleBackColor = true;
            // 
            // dimmer0
            // 
            this.dimmer0.AutoSize = true;
            this.dimmer0.Location = new System.Drawing.Point(13, 137);
            this.dimmer0.Name = "dimmer0";
            this.dimmer0.Size = new System.Drawing.Size(14, 13);
            this.dimmer0.TabIndex = 5;
            this.dimmer0.TabStop = true;
            this.dimmer0.UseVisualStyleBackColor = true;
            // 
            // bigButton
            // 
            this.bigButton.Location = new System.Drawing.Point(34, 42);
            this.bigButton.Name = "bigButton";
            this.bigButton.Size = new System.Drawing.Size(23, 108);
            this.bigButton.TabIndex = 6;
            this.bigButton.UseVisualStyleBackColor = true;
            this.bigButton.Click += new System.EventHandler(this.bigButton_Click);
            // 
            // dimmerUpButton
            // 
            this.dimmerUpButton.Location = new System.Drawing.Point(116, 61);
            this.dimmerUpButton.Name = "dimmerUpButton";
            this.dimmerUpButton.Size = new System.Drawing.Size(15, 32);
            this.dimmerUpButton.TabIndex = 7;
            this.dimmerUpButton.UseVisualStyleBackColor = true;
            this.dimmerUpButton.Click += new System.EventHandler(this.dimmerUpButton_Click);
            // 
            // dimmerDownButton
            // 
            this.dimmerDownButton.Location = new System.Drawing.Point(116, 99);
            this.dimmerDownButton.Name = "dimmerDownButton";
            this.dimmerDownButton.Size = new System.Drawing.Size(15, 32);
            this.dimmerDownButton.TabIndex = 8;
            this.dimmerDownButton.UseVisualStyleBackColor = true;
            this.dimmerDownButton.Click += new System.EventHandler(this.dimmerDownButton_Click);
            // 
            // lightBrightnessDisplay
            // 
            this.lightBrightnessDisplay.AutoSize = true;
            this.lightBrightnessDisplay.Location = new System.Drawing.Point(31, 172);
            this.lightBrightnessDisplay.Name = "lightBrightnessDisplay";
            this.lightBrightnessDisplay.Size = new System.Drawing.Size(58, 13);
            this.lightBrightnessDisplay.TabIndex = 9;
            this.lightBrightnessDisplay.Text = "                 ";
            // 
            // bigButtonDoubleClick
            // 
            this.bigButtonDoubleClick.Location = new System.Drawing.Point(63, 42);
            this.bigButtonDoubleClick.Name = "bigButtonDoubleClick";
            this.bigButtonDoubleClick.Size = new System.Drawing.Size(47, 108);
            this.bigButtonDoubleClick.TabIndex = 10;
            this.bigButtonDoubleClick.UseVisualStyleBackColor = true;
            this.bigButtonDoubleClick.Click += new System.EventHandler(this.bigButtonDoubleClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 239);
            this.Controls.Add(this.bigButtonDoubleClick);
            this.Controls.Add(this.lightBrightnessDisplay);
            this.Controls.Add(this.dimmerDownButton);
            this.Controls.Add(this.dimmerUpButton);
            this.Controls.Add(this.bigButton);
            this.Controls.Add(this.dimmer0);
            this.Controls.Add(this.dimmer1);
            this.Controls.Add(this.dimmer2);
            this.Controls.Add(this.dimmer3);
            this.Controls.Add(this.dimmer4);
            this.Controls.Add(this.dimmer5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dimmer5;
        private System.Windows.Forms.RadioButton dimmer4;
        private System.Windows.Forms.RadioButton dimmer3;
        private System.Windows.Forms.RadioButton dimmer2;
        private System.Windows.Forms.RadioButton dimmer1;
        private System.Windows.Forms.RadioButton dimmer0;
        private System.Windows.Forms.Button bigButton;
        private System.Windows.Forms.Button dimmerUpButton;
        private System.Windows.Forms.Button dimmerDownButton;
        private System.Windows.Forms.Label lightBrightnessDisplay;
        private System.Windows.Forms.Button bigButtonDoubleClick;
    }
}

