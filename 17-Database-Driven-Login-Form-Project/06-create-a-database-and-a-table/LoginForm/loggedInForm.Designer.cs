namespace LoginForm
{
    partial class loggedInForm
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
            this.closeSuccessWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have logged in successfully!";
            // 
            // closeSuccessWindowButton
            // 
            this.closeSuccessWindowButton.BackColor = System.Drawing.Color.MintCream;
            this.closeSuccessWindowButton.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSuccessWindowButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.closeSuccessWindowButton.Location = new System.Drawing.Point(282, 98);
            this.closeSuccessWindowButton.Name = "closeSuccessWindowButton";
            this.closeSuccessWindowButton.Size = new System.Drawing.Size(76, 34);
            this.closeSuccessWindowButton.TabIndex = 7;
            this.closeSuccessWindowButton.Text = "Close";
            this.closeSuccessWindowButton.UseVisualStyleBackColor = false;
            this.closeSuccessWindowButton.Click += new System.EventHandler(this.closeSuccessWindowButton_Click);
            // 
            // loggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(408, 162);
            this.Controls.Add(this.closeSuccessWindowButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "loggedInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You Got In!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeSuccessWindowButton;
    }
}