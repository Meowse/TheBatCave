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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
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
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(59, 198);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 9;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(203, 198);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(59, 263);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 12;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(257, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(257, 233);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 23);
            this.btnEquals.TabIndex = 14;
            this.btnEquals.Text = "Equals";
            this.btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(158, 263);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 15;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(158, 233);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 328);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
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
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiply;
    }
}

