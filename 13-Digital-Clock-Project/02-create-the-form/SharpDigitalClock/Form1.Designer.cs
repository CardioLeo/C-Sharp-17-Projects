namespace SharpDigitalClock
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
            this.hourMinute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourMinute
            // 
            this.hourMinute.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMinute.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.hourMinute.Location = new System.Drawing.Point(45, 38);
            this.hourMinute.Name = "hourMinute";
            this.hourMinute.Size = new System.Drawing.Size(409, 173);
            this.hourMinute.TabIndex = 0;
            this.hourMinute.Text = "19:25";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(496, 261);
            this.Controls.Add(this.hourMinute);
            this.Name = "Form1";
            this.Text = "Sharp Digital Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hourMinute;
    }
}

