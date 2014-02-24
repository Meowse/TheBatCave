namespace WritingDesk
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
            this.currentPage = new System.Windows.Forms.TextBox();
            this.getNewPageButton = new System.Windows.Forms.Button();
            this.buyFeltTipPenButton = new System.Windows.Forms.Button();
            this.buyCheapBallPointPenButton = new System.Windows.Forms.Button();
            this.buyExpensiveBallPointPenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentPenLabel = new System.Windows.Forms.Label();
            this.writeSomethingButton = new System.Windows.Forms.Button();
            this.waitFiveMinutesButton = new System.Windows.Forms.Button();
            this.waitOneHourButton = new System.Windows.Forms.Button();
            this.capPenButton = new System.Windows.Forms.Button();
            this.uncapPenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paper:";
            // 
            // currentPage
            // 
            this.currentPage.Location = new System.Drawing.Point(16, 166);
            this.currentPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentPage.Multiline = true;
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(417, 210);
            this.currentPage.TabIndex = 1;
            // 
            // getNewPageButton
            // 
            this.getNewPageButton.Location = new System.Drawing.Point(443, 348);
            this.getNewPageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getNewPageButton.Name = "getNewPageButton";
            this.getNewPageButton.Size = new System.Drawing.Size(100, 28);
            this.getNewPageButton.TabIndex = 2;
            this.getNewPageButton.Text = "New Page";
            this.getNewPageButton.UseVisualStyleBackColor = true;
            this.getNewPageButton.Click += new System.EventHandler(this.getNewPageButton_Click);
            // 
            // buyFeltTipPenButton
            // 
            this.buyFeltTipPenButton.Location = new System.Drawing.Point(495, 47);
            this.buyFeltTipPenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyFeltTipPenButton.Name = "buyFeltTipPenButton";
            this.buyFeltTipPenButton.Size = new System.Drawing.Size(241, 28);
            this.buyFeltTipPenButton.TabIndex = 3;
            this.buyFeltTipPenButton.Text = "Buy Felt Tip Pen";
            this.buyFeltTipPenButton.UseVisualStyleBackColor = true;
            this.buyFeltTipPenButton.Click += new System.EventHandler(this.buyFeltTipPenButton_Click);
            // 
            // buyCheapBallPointPenButton
            // 
            this.buyCheapBallPointPenButton.Location = new System.Drawing.Point(495, 82);
            this.buyCheapBallPointPenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyCheapBallPointPenButton.Name = "buyCheapBallPointPenButton";
            this.buyCheapBallPointPenButton.Size = new System.Drawing.Size(241, 28);
            this.buyCheapBallPointPenButton.TabIndex = 4;
            this.buyCheapBallPointPenButton.Text = "Buy Cheap Ball-Point Pen";
            this.buyCheapBallPointPenButton.UseVisualStyleBackColor = true;
            this.buyCheapBallPointPenButton.Click += new System.EventHandler(this.buyCheapBallPointPenButton_Click);
            // 
            // buyExpensiveBallPointPenButton
            // 
            this.buyExpensiveBallPointPenButton.Location = new System.Drawing.Point(495, 118);
            this.buyExpensiveBallPointPenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyExpensiveBallPointPenButton.Name = "buyExpensiveBallPointPenButton";
            this.buyExpensiveBallPointPenButton.Size = new System.Drawing.Size(241, 28);
            this.buyExpensiveBallPointPenButton.TabIndex = 5;
            this.buyExpensiveBallPointPenButton.Text = "Buy Expensive Ball-Point Pen";
            this.buyExpensiveBallPointPenButton.UseVisualStyleBackColor = true;
            this.buyExpensiveBallPointPenButton.Click += new System.EventHandler(this.buyExpensiveBallPointPenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pen:";
            // 
            // currentPenLabel
            // 
            this.currentPenLabel.AutoSize = true;
            this.currentPenLabel.Location = new System.Drawing.Point(68, 34);
            this.currentPenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPenLabel.Name = "currentPenLabel";
            this.currentPenLabel.Size = new System.Drawing.Size(174, 17);
            this.currentPenLabel.TabIndex = 7;
            this.currentPenLabel.Text = "You do not own a pen.      ";
            // 
            // writeSomethingButton
            // 
            this.writeSomethingButton.Location = new System.Drawing.Point(16, 113);
            this.writeSomethingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.writeSomethingButton.Name = "writeSomethingButton";
            this.writeSomethingButton.Size = new System.Drawing.Size(177, 28);
            this.writeSomethingButton.TabIndex = 8;
            this.writeSomethingButton.Text = "Write Something!";
            this.writeSomethingButton.UseVisualStyleBackColor = true;
            this.writeSomethingButton.Click += new System.EventHandler(this.writeSomethingButton_Click);
            // 
            // waitFiveMinutesButton
            // 
            this.waitFiveMinutesButton.Location = new System.Drawing.Point(495, 208);
            this.waitFiveMinutesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waitFiveMinutesButton.Name = "waitFiveMinutesButton";
            this.waitFiveMinutesButton.Size = new System.Drawing.Size(241, 28);
            this.waitFiveMinutesButton.TabIndex = 9;
            this.waitFiveMinutesButton.Text = "5 Minutes of Writer\'s Block";
            this.waitFiveMinutesButton.UseVisualStyleBackColor = true;
            this.waitFiveMinutesButton.Click += new System.EventHandler(this.waitFiveMinutesButton_Click);
            // 
            // waitOneHourButton
            // 
            this.waitOneHourButton.Location = new System.Drawing.Point(495, 244);
            this.waitOneHourButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waitOneHourButton.Name = "waitOneHourButton";
            this.waitOneHourButton.Size = new System.Drawing.Size(241, 28);
            this.waitOneHourButton.TabIndex = 10;
            this.waitOneHourButton.Text = "1 Hour of Writer\'s Block";
            this.waitOneHourButton.UseVisualStyleBackColor = true;
            this.waitOneHourButton.Click += new System.EventHandler(this.waitOneHourButton_Click);
            // 
            // capPenButton
            // 
            this.capPenButton.Location = new System.Drawing.Point(16, 66);
            this.capPenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.capPenButton.Name = "capPenButton";
            this.capPenButton.Size = new System.Drawing.Size(177, 28);
            this.capPenButton.TabIndex = 11;
            this.capPenButton.Text = "Cap Your Pen";
            this.capPenButton.UseVisualStyleBackColor = true;
            this.capPenButton.Click += new System.EventHandler(this.capPenButton_Click);
            // 
            // uncapPenButton
            // 
            this.uncapPenButton.Location = new System.Drawing.Point(213, 66);
            this.uncapPenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uncapPenButton.Name = "uncapPenButton";
            this.uncapPenButton.Size = new System.Drawing.Size(177, 28);
            this.uncapPenButton.TabIndex = 12;
            this.uncapPenButton.Text = "Un-Cap Your Pen";
            this.uncapPenButton.UseVisualStyleBackColor = true;
            this.uncapPenButton.Click += new System.EventHandler(this.uncapPenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 391);
            this.Controls.Add(this.uncapPenButton);
            this.Controls.Add(this.capPenButton);
            this.Controls.Add(this.waitOneHourButton);
            this.Controls.Add(this.waitFiveMinutesButton);
            this.Controls.Add(this.writeSomethingButton);
            this.Controls.Add(this.currentPenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyExpensiveBallPointPenButton);
            this.Controls.Add(this.buyCheapBallPointPenButton);
            this.Controls.Add(this.buyFeltTipPenButton);
            this.Controls.Add(this.getNewPageButton);
            this.Controls.Add(this.currentPage);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentPage;
        private System.Windows.Forms.Button getNewPageButton;
        private System.Windows.Forms.Button buyFeltTipPenButton;
        private System.Windows.Forms.Button buyCheapBallPointPenButton;
        private System.Windows.Forms.Button buyExpensiveBallPointPenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentPenLabel;
        private System.Windows.Forms.Button writeSomethingButton;
        private System.Windows.Forms.Button waitFiveMinutesButton;
        private System.Windows.Forms.Button waitOneHourButton;
        private System.Windows.Forms.Button capPenButton;
        private System.Windows.Forms.Button uncapPenButton;
    }
}

