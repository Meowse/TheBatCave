namespace FizzBuzzInfinite
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
            this.tbDevisor = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lblDevisor = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFizzBuzz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbCountTo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCountTo = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDevisor
            // 
            this.tbDevisor.Location = new System.Drawing.Point(48, 53);
            this.tbDevisor.Name = "tbDevisor";
            this.tbDevisor.Size = new System.Drawing.Size(100, 22);
            this.tbDevisor.TabIndex = 0;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(48, 122);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(100, 22);
            this.tbMessage.TabIndex = 1;
            // 
            // lblDevisor
            // 
            this.lblDevisor.AutoSize = true;
            this.lblDevisor.Location = new System.Drawing.Point(45, 33);
            this.lblDevisor.Name = "lblDevisor";
            this.lblDevisor.Size = new System.Drawing.Size(56, 17);
            this.lblDevisor.TabIndex = 2;
            this.lblDevisor.Text = "Devisor";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(45, 102);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 17);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(48, 165);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(107, 32);
            this.btnAddToList.TabIndex = 4;
            this.btnAddToList.Text = "Add to list";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(125, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFizzBuzz
            // 
            this.btnFizzBuzz.Location = new System.Drawing.Point(47, 165);
            this.btnFizzBuzz.Name = "btnFizzBuzz";
            this.btnFizzBuzz.Size = new System.Drawing.Size(107, 32);
            this.btnFizzBuzz.TabIndex = 6;
            this.btnFizzBuzz.Text = "Fizbuzz!";
            this.btnFizzBuzz.UseVisualStyleBackColor = true;
            this.btnFizzBuzz.Click += new System.EventHandler(this.btnFizzBuzz_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(374, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbCountTo
            // 
            this.tbCountTo.Location = new System.Drawing.Point(47, 53);
            this.tbCountTo.Name = "tbCountTo";
            this.tbCountTo.Size = new System.Drawing.Size(100, 22);
            this.tbCountTo.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowList);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.tbDevisor);
            this.groupBox1.Controls.Add(this.lblDevisor);
            this.groupBox1.Controls.Add(this.tbMessage);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Location = new System.Drawing.Point(52, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 305);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create the list";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCountTo);
            this.groupBox2.Controls.Add(this.tbCountTo);
            this.groupBox2.Controls.Add(this.btnFizzBuzz);
            this.groupBox2.Location = new System.Drawing.Point(305, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 216);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Do the thing!";
            // 
            // lblCountTo
            // 
            this.lblCountTo.AutoSize = true;
            this.lblCountTo.Location = new System.Drawing.Point(47, 33);
            this.lblCountTo.Name = "lblCountTo";
            this.lblCountTo.Size = new System.Drawing.Size(66, 17);
            this.lblCountTo.TabIndex = 9;
            this.lblCountTo.Text = "Count To";
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(48, 236);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(107, 31);
            this.btnShowList.TabIndex = 5;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDevisor;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lblDevisor;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFizzBuzz;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbCountTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCountTo;
        private System.Windows.Forms.Button btnShowList;
    }
}

