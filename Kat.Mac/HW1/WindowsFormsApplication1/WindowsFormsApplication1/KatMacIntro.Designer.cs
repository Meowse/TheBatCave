namespace WindowsFormsApplication1
{
    partial class HWAssign1
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
            this.PopCultQuestion = new System.Windows.Forms.Label();
            this.DrWho = new System.Windows.Forms.RadioButton();
            this.LOTR = new System.Windows.Forms.RadioButton();
            this.HarryPotter = new System.Windows.Forms.RadioButton();
            this.GoT = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.HungerGames = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // PopCultQuestion
            // 
            this.PopCultQuestion.AutoSize = true;
            this.PopCultQuestion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopCultQuestion.Location = new System.Drawing.Point(10, 30);
            this.PopCultQuestion.Margin = new System.Windows.Forms.Padding(1);
            this.PopCultQuestion.MaximumSize = new System.Drawing.Size(450, 0);
            this.PopCultQuestion.Name = "PopCultQuestion";
            this.PopCultQuestion.Size = new System.Drawing.Size(339, 15);
            this.PopCultQuestion.TabIndex = 0;
            this.PopCultQuestion.Text = "Which popular culture show or movie do you enjoy watching?";
            this.PopCultQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // DrWho
            // 
            this.DrWho.AutoSize = true;
            this.DrWho.Location = new System.Drawing.Point(47, 64);
            this.DrWho.Name = "DrWho";
            this.DrWho.Size = new System.Drawing.Size(65, 17);
            this.DrWho.TabIndex = 1;
            this.DrWho.TabStop = true;
            this.DrWho.Text = "Dr. Who";
            this.DrWho.UseVisualStyleBackColor = true;
            // 
            // LOTR
            // 
            this.LOTR.AutoSize = true;
            this.LOTR.Location = new System.Drawing.Point(47, 82);
            this.LOTR.Name = "LOTR";
            this.LOTR.Size = new System.Drawing.Size(106, 17);
            this.LOTR.TabIndex = 2;
            this.LOTR.TabStop = true;
            this.LOTR.Text = "Lord of the Rings";
            this.LOTR.UseVisualStyleBackColor = true;
            this.LOTR.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // HarryPotter
            // 
            this.HarryPotter.AutoSize = true;
            this.HarryPotter.Location = new System.Drawing.Point(47, 100);
            this.HarryPotter.Name = "HarryPotter";
            this.HarryPotter.Size = new System.Drawing.Size(81, 17);
            this.HarryPotter.TabIndex = 3;
            this.HarryPotter.TabStop = true;
            this.HarryPotter.Text = "Harry Potter";
            this.HarryPotter.UseVisualStyleBackColor = true;
            this.HarryPotter.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // GoT
            // 
            this.GoT.AutoSize = true;
            this.GoT.Location = new System.Drawing.Point(47, 118);
            this.GoT.Name = "GoT";
            this.GoT.Size = new System.Drawing.Size(107, 17);
            this.GoT.TabIndex = 4;
            this.GoT.TabStop = true;
            this.GoT.Text = "Game of Thrones";
            this.GoT.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Navy;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(239, 199);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Navy;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(328, 199);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HungerGames
            // 
            this.HungerGames.AutoSize = true;
            this.HungerGames.Location = new System.Drawing.Point(47, 136);
            this.HungerGames.Name = "HungerGames";
            this.HungerGames.Size = new System.Drawing.Size(96, 17);
            this.HungerGames.TabIndex = 7;
            this.HungerGames.TabStop = true;
            this.HungerGames.Text = "Hunger Games";
            this.HungerGames.UseVisualStyleBackColor = true;
            this.HungerGames.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // HWAssign1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(420, 234);
            this.Controls.Add(this.HungerGames);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.GoT);
            this.Controls.Add(this.HarryPotter);
            this.Controls.Add(this.LOTR);
            this.Controls.Add(this.DrWho);
            this.Controls.Add(this.PopCultQuestion);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "HWAssign1";
            this.Text = "Homework Assignment 1: Getting to Know Visual Studio";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PopCultQuestion;
        private System.Windows.Forms.RadioButton DrWho;
        private System.Windows.Forms.RadioButton LOTR;
        private System.Windows.Forms.RadioButton HarryPotter;
        private System.Windows.Forms.RadioButton GoT;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RadioButton HungerGames;

    }
}

