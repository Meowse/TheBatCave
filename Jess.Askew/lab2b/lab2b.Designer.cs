namespace Lab2b
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.evaName = new System.Windows.Forms.Label();
            this.taName = new System.Windows.Forms.Label();
            this.mickeyName = new System.Windows.Forms.Label();
            this.instructorName = new System.Windows.Forms.Label();
            this.fixEvaNameButton = new System.Windows.Forms.Button();
            this.fixMickeyNameButton = new System.Windows.Forms.Button();
            this.askForHelpButton = new System.Windows.Forms.Button();
            this.giveMickeyMartianMeaslesButton = new System.Windows.Forms.Button();
            this.mickeyShameNameChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eva: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mickey:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Instructor:";
            // 
            // evaName
            // 
            this.evaName.AutoSize = true;
            this.evaName.Location = new System.Drawing.Point(70, 13);
            this.evaName.Name = "evaName";
            this.evaName.Size = new System.Drawing.Size(112, 13);
            this.evaName.TabIndex = 4;
            this.evaName.Text = "Eva\'s name goes here";
            this.evaName.Click += new System.EventHandler(this.evaName_Click);
            // 
            // taName
            // 
            this.taName.AutoSize = true;
            this.taName.Location = new System.Drawing.Point(70, 37);
            this.taName.Name = "taName";
            this.taName.Size = new System.Drawing.Size(129, 13);
            this.taName.TabIndex = 5;
            this.taName.Text = "The TA\'s name goes here";
            // 
            // mickeyName
            // 
            this.mickeyName.AutoSize = true;
            this.mickeyName.Location = new System.Drawing.Point(70, 61);
            this.mickeyName.Name = "mickeyName";
            this.mickeyName.Size = new System.Drawing.Size(127, 13);
            this.mickeyName.TabIndex = 6;
            this.mickeyName.Text = "Mickey\'s name goes here";
            // 
            // instructorName
            // 
            this.instructorName.AutoSize = true;
            this.instructorName.Location = new System.Drawing.Point(70, 85);
            this.instructorName.Name = "instructorName";
            this.instructorName.Size = new System.Drawing.Size(158, 13);
            this.instructorName.TabIndex = 7;
            this.instructorName.Text = "The instructor\'s name goes here";
            // 
            // fixEvaNameButton
            // 
            this.fixEvaNameButton.Location = new System.Drawing.Point(16, 114);
            this.fixEvaNameButton.Name = "fixEvaNameButton";
            this.fixEvaNameButton.Size = new System.Drawing.Size(212, 23);
            this.fixEvaNameButton.TabIndex = 8;
            this.fixEvaNameButton.Text = "1) Fix Eva\'s name";
            this.fixEvaNameButton.UseVisualStyleBackColor = true;
            this.fixEvaNameButton.Click += new System.EventHandler(this.fixEvaNameButton_Click);
            // 
            // fixMickeyNameButton
            // 
            this.fixMickeyNameButton.Location = new System.Drawing.Point(16, 143);
            this.fixMickeyNameButton.Name = "fixMickeyNameButton";
            this.fixMickeyNameButton.Size = new System.Drawing.Size(212, 23);
            this.fixMickeyNameButton.TabIndex = 9;
            this.fixMickeyNameButton.Text = "2) Fix Mickey\'s name";
            this.fixMickeyNameButton.UseVisualStyleBackColor = true;
            this.fixMickeyNameButton.Click += new System.EventHandler(this.fixMickeyNameButton_Click);
            // 
            // askForHelpButton
            // 
            this.askForHelpButton.Location = new System.Drawing.Point(16, 172);
            this.askForHelpButton.Name = "askForHelpButton";
            this.askForHelpButton.Size = new System.Drawing.Size(212, 23);
            this.askForHelpButton.TabIndex = 10;
            this.askForHelpButton.Text = "3) Ask TA for help, then instructor";
            this.askForHelpButton.UseVisualStyleBackColor = true;
            this.askForHelpButton.Click += new System.EventHandler(this.askForHelpButton_Click);
            // 
            // giveMickeyMartianMeaslesButton
            // 
            this.giveMickeyMartianMeaslesButton.Location = new System.Drawing.Point(16, 201);
            this.giveMickeyMartianMeaslesButton.Name = "giveMickeyMartianMeaslesButton";
            this.giveMickeyMartianMeaslesButton.Size = new System.Drawing.Size(212, 23);
            this.giveMickeyMartianMeaslesButton.TabIndex = 11;
            this.giveMickeyMartianMeaslesButton.Text = "4) Give Mickey the Martian Measles";
            this.giveMickeyMartianMeaslesButton.UseVisualStyleBackColor = true;
            this.giveMickeyMartianMeaslesButton.Click += new System.EventHandler(this.giveMickeyMartianMeaslesButton_Click);
            // 
            // mickeyShameNameChangeButton
            // 
            this.mickeyShameNameChangeButton.Location = new System.Drawing.Point(16, 227);
            this.mickeyShameNameChangeButton.Name = "mickeyShameNameChangeButton";
            this.mickeyShameNameChangeButton.Size = new System.Drawing.Size(212, 23);
            this.mickeyShameNameChangeButton.TabIndex = 12;
            this.mickeyShameNameChangeButton.Text = "5) Shame-change Mickey\'s name";
            this.mickeyShameNameChangeButton.UseVisualStyleBackColor = true;
            this.mickeyShameNameChangeButton.Click += new System.EventHandler(this.mickeyShameNameChangeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mickeyShameNameChangeButton);
            this.Controls.Add(this.giveMickeyMartianMeaslesButton);
            this.Controls.Add(this.askForHelpButton);
            this.Controls.Add(this.fixMickeyNameButton);
            this.Controls.Add(this.fixEvaNameButton);
            this.Controls.Add(this.instructorName);
            this.Controls.Add(this.mickeyName);
            this.Controls.Add(this.taName);
            this.Controls.Add(this.evaName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label evaName;
        private System.Windows.Forms.Label taName;
        private System.Windows.Forms.Label mickeyName;
        private System.Windows.Forms.Label instructorName;
        private System.Windows.Forms.Button fixEvaNameButton;
        private System.Windows.Forms.Button fixMickeyNameButton;
        private System.Windows.Forms.Button askForHelpButton;
        private System.Windows.Forms.Button giveMickeyMartianMeaslesButton;
        private System.Windows.Forms.Button mickeyShameNameChangeButton;
    }
}

