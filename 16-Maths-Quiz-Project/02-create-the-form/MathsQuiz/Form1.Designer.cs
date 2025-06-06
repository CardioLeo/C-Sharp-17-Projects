﻿namespace MathsQuiz
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftTextBox = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.sumSelector = new System.Windows.Forms.NumericUpDown();
            this.plusSignLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusEqualsLabel = new System.Windows.Forms.Label();
            this.minusEqualsSign = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLabel = new System.Windows.Forms.Label();
            this.differenceSelector = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.timesEqualsLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLabel = new System.Windows.Forms.Label();
            this.productSelector = new System.Windows.Forms.NumericUpDown();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.divisionEqualsSign = new System.Windows.Forms.Label();
            this.divisionRightLabel = new System.Windows.Forms.Label();
            this.divisionLabel = new System.Windows.Forms.Label();
            this.quotientSelector = new System.Windows.Forms.NumericUpDown();
            this.divisionLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkAnswersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sumSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotientSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Bisque;
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 39);
            this.timeLabel.TabIndex = 0;
            // 
            // timeLeftTextBox
            // 
            this.timeLeftTextBox.AutoSize = true;
            this.timeLeftTextBox.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftTextBox.ForeColor = System.Drawing.Color.Bisque;
            this.timeLeftTextBox.Location = new System.Drawing.Point(161, 9);
            this.timeLeftTextBox.Name = "timeLeftTextBox";
            this.timeLeftTextBox.Size = new System.Drawing.Size(105, 27);
            this.timeLeftTextBox.TabIndex = 1;
            this.timeLeftTextBox.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.ForeColor = System.Drawing.Color.Bisque;
            this.plusLeftLabel.Location = new System.Drawing.Point(42, 79);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumSelector
            // 
            this.sumSelector.BackColor = System.Drawing.Color.Bisque;
            this.sumSelector.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumSelector.ForeColor = System.Drawing.Color.Salmon;
            this.sumSelector.Location = new System.Drawing.Point(318, 93);
            this.sumSelector.Name = "sumSelector";
            this.sumSelector.Size = new System.Drawing.Size(92, 30);
            this.sumSelector.TabIndex = 2;
            // 
            // plusSignLabel
            // 
            this.plusSignLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSignLabel.ForeColor = System.Drawing.Color.Bisque;
            this.plusSignLabel.Location = new System.Drawing.Point(108, 79);
            this.plusSignLabel.Name = "plusSignLabel";
            this.plusSignLabel.Size = new System.Drawing.Size(60, 50);
            this.plusSignLabel.TabIndex = 7;
            this.plusSignLabel.Text = "+";
            this.plusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.ForeColor = System.Drawing.Color.Bisque;
            this.plusRightLabel.Location = new System.Drawing.Point(174, 79);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 8;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusEqualsLabel
            // 
            this.plusEqualsLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusEqualsLabel.ForeColor = System.Drawing.Color.Bisque;
            this.plusEqualsLabel.Location = new System.Drawing.Point(237, 79);
            this.plusEqualsLabel.Name = "plusEqualsLabel";
            this.plusEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.plusEqualsLabel.TabIndex = 9;
            this.plusEqualsLabel.Text = "=";
            this.plusEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusEqualsSign
            // 
            this.minusEqualsSign.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusEqualsSign.ForeColor = System.Drawing.Color.Bisque;
            this.minusEqualsSign.Location = new System.Drawing.Point(237, 129);
            this.minusEqualsSign.Name = "minusEqualsSign";
            this.minusEqualsSign.Size = new System.Drawing.Size(60, 50);
            this.minusEqualsSign.TabIndex = 14;
            this.minusEqualsSign.Text = "=";
            this.minusEqualsSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.ForeColor = System.Drawing.Color.Bisque;
            this.minusRightLabel.Location = new System.Drawing.Point(174, 129);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 13;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLabel
            // 
            this.minusLabel.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLabel.ForeColor = System.Drawing.Color.Bisque;
            this.minusLabel.Location = new System.Drawing.Point(108, 129);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLabel.TabIndex = 12;
            this.minusLabel.Text = "-";
            this.minusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // differenceSelector
            // 
            this.differenceSelector.BackColor = System.Drawing.Color.Bisque;
            this.differenceSelector.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceSelector.ForeColor = System.Drawing.Color.Salmon;
            this.differenceSelector.Location = new System.Drawing.Point(318, 143);
            this.differenceSelector.Name = "differenceSelector";
            this.differenceSelector.Size = new System.Drawing.Size(92, 30);
            this.differenceSelector.TabIndex = 3;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.ForeColor = System.Drawing.Color.Bisque;
            this.minusLeftLabel.Location = new System.Drawing.Point(42, 129);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 10;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesEqualsLabel
            // 
            this.timesEqualsLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesEqualsLabel.ForeColor = System.Drawing.Color.Bisque;
            this.timesEqualsLabel.Location = new System.Drawing.Point(237, 179);
            this.timesEqualsLabel.Name = "timesEqualsLabel";
            this.timesEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.timesEqualsLabel.TabIndex = 19;
            this.timesEqualsLabel.Text = "=";
            this.timesEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.ForeColor = System.Drawing.Color.Bisque;
            this.timesRightLabel.Location = new System.Drawing.Point(174, 179);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 18;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLabel
            // 
            this.timesLabel.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLabel.ForeColor = System.Drawing.Color.Bisque;
            this.timesLabel.Location = new System.Drawing.Point(108, 179);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLabel.TabIndex = 17;
            this.timesLabel.Text = "x";
            this.timesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productSelector
            // 
            this.productSelector.BackColor = System.Drawing.Color.Bisque;
            this.productSelector.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSelector.ForeColor = System.Drawing.Color.Salmon;
            this.productSelector.Location = new System.Drawing.Point(318, 193);
            this.productSelector.Name = "productSelector";
            this.productSelector.Size = new System.Drawing.Size(92, 30);
            this.productSelector.TabIndex = 4;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.ForeColor = System.Drawing.Color.Bisque;
            this.timesLeftLabel.Location = new System.Drawing.Point(42, 179);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 15;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisionEqualsSign
            // 
            this.divisionEqualsSign.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionEqualsSign.ForeColor = System.Drawing.Color.Bisque;
            this.divisionEqualsSign.Location = new System.Drawing.Point(237, 229);
            this.divisionEqualsSign.Name = "divisionEqualsSign";
            this.divisionEqualsSign.Size = new System.Drawing.Size(60, 50);
            this.divisionEqualsSign.TabIndex = 24;
            this.divisionEqualsSign.Text = "=";
            this.divisionEqualsSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisionRightLabel
            // 
            this.divisionRightLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionRightLabel.ForeColor = System.Drawing.Color.Bisque;
            this.divisionRightLabel.Location = new System.Drawing.Point(174, 229);
            this.divisionRightLabel.Name = "divisionRightLabel";
            this.divisionRightLabel.Size = new System.Drawing.Size(60, 50);
            this.divisionRightLabel.TabIndex = 23;
            this.divisionRightLabel.Text = "?";
            this.divisionRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisionLabel
            // 
            this.divisionLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionLabel.ForeColor = System.Drawing.Color.Bisque;
            this.divisionLabel.Location = new System.Drawing.Point(108, 229);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(60, 50);
            this.divisionLabel.TabIndex = 22;
            this.divisionLabel.Text = "/";
            this.divisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotientSelector
            // 
            this.quotientSelector.BackColor = System.Drawing.Color.Bisque;
            this.quotientSelector.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotientSelector.ForeColor = System.Drawing.Color.Salmon;
            this.quotientSelector.Location = new System.Drawing.Point(318, 243);
            this.quotientSelector.Name = "quotientSelector";
            this.quotientSelector.Size = new System.Drawing.Size(92, 30);
            this.quotientSelector.TabIndex = 5;
            // 
            // divisionLeftLabel
            // 
            this.divisionLeftLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionLeftLabel.ForeColor = System.Drawing.Color.Bisque;
            this.divisionLeftLabel.Location = new System.Drawing.Point(42, 229);
            this.divisionLeftLabel.Name = "divisionLeftLabel";
            this.divisionLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.divisionLeftLabel.TabIndex = 20;
            this.divisionLeftLabel.Text = "?";
            this.divisionLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Bisque;
            this.startButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Salmon;
            this.startButton.Location = new System.Drawing.Point(75, 294);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Quiz";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkAnswersButton
            // 
            this.checkAnswersButton.BackColor = System.Drawing.Color.Bisque;
            this.checkAnswersButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAnswersButton.ForeColor = System.Drawing.Color.Salmon;
            this.checkAnswersButton.Location = new System.Drawing.Point(238, 294);
            this.checkAnswersButton.Name = "checkAnswersButton";
            this.checkAnswersButton.Size = new System.Drawing.Size(185, 44);
            this.checkAnswersButton.TabIndex = 25;
            this.checkAnswersButton.Text = "Check Answers";
            this.checkAnswersButton.UseVisualStyleBackColor = false;
            this.checkAnswersButton.Click += new System.EventHandler(this.checkAnswersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.checkAnswersButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.divisionEqualsSign);
            this.Controls.Add(this.divisionRightLabel);
            this.Controls.Add(this.divisionLabel);
            this.Controls.Add(this.quotientSelector);
            this.Controls.Add(this.divisionLeftLabel);
            this.Controls.Add(this.timesEqualsLabel);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.productSelector);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.minusEqualsSign);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLabel);
            this.Controls.Add(this.differenceSelector);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.plusEqualsLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusSignLabel);
            this.Controls.Add(this.sumSelector);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftTextBox);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sharp Maths Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sumSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotientSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftTextBox;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.NumericUpDown sumSelector;
        private System.Windows.Forms.Label plusSignLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusEqualsLabel;
        private System.Windows.Forms.Label minusEqualsSign;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.NumericUpDown differenceSelector;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label timesEqualsLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.NumericUpDown productSelector;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label divisionEqualsSign;
        private System.Windows.Forms.Label divisionRightLabel;
        private System.Windows.Forms.Label divisionLabel;
        private System.Windows.Forms.NumericUpDown quotientSelector;
        private System.Windows.Forms.Label divisionLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button checkAnswersButton;
    }
}

