namespace TriangleTyperApp
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
            this.sideAField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sideBField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sideCField = new System.Windows.Forms.TextBox();
            this.typeItButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.triangleTypeDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideAField
            // 
            this.sideAField.Location = new System.Drawing.Point(59, 12);
            this.sideAField.Name = "sideAField";
            this.sideAField.Size = new System.Drawing.Size(240, 20);
            this.sideAField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Side A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Side B:";
            // 
            // sideBField
            // 
            this.sideBField.Location = new System.Drawing.Point(59, 38);
            this.sideBField.Name = "sideBField";
            this.sideBField.Size = new System.Drawing.Size(240, 20);
            this.sideBField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Side C:";
            // 
            // sideCField
            // 
            this.sideCField.Location = new System.Drawing.Point(59, 64);
            this.sideCField.Name = "sideCField";
            this.sideCField.Size = new System.Drawing.Size(240, 20);
            this.sideCField.TabIndex = 4;
            // 
            // typeItButton
            // 
            this.typeItButton.Location = new System.Drawing.Point(223, 91);
            this.typeItButton.Name = "typeItButton";
            this.typeItButton.Size = new System.Drawing.Size(75, 23);
            this.typeItButton.TabIndex = 6;
            this.typeItButton.Text = "Type it!";
            this.typeItButton.UseVisualStyleBackColor = true;
            this.typeItButton.Click += new System.EventHandler(this.typeItButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Triangle Type:";
            // 
            // triangleTypeDisplay
            // 
            this.triangleTypeDisplay.AutoSize = true;
            this.triangleTypeDisplay.Location = new System.Drawing.Point(137, 121);
            this.triangleTypeDisplay.Name = "triangleTypeDisplay";
            this.triangleTypeDisplay.Size = new System.Drawing.Size(160, 13);
            this.triangleTypeDisplay.TabIndex = 8;
            this.triangleTypeDisplay.Text = "                                                   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 185);
            this.Controls.Add(this.triangleTypeDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeItButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sideCField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sideBField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sideAField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sideAField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sideBField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sideCField;
        private System.Windows.Forms.Button typeItButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label triangleTypeDisplay;
    }
}

