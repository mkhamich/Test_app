namespace TestApp
{
    partial class Form2
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
            this.lblLogFileText = new System.Windows.Forms.Label();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogFileText
            // 
            this.lblLogFileText.AutoSize = true;
            this.lblLogFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogFileText.Location = new System.Drawing.Point(12, 9);
            this.lblLogFileText.Name = "lblLogFileText";
            this.lblLogFileText.Size = new System.Drawing.Size(101, 31);
            this.lblLogFileText.TabIndex = 0;
            this.lblLogFileText.Text = "Log file\r\n";
            // 
            // txtLogFile
            // 
            this.txtLogFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLogFile.Location = new System.Drawing.Point(18, 53);
            this.txtLogFile.Multiline = true;
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.ReadOnly = true;
            this.txtLogFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogFile.Size = new System.Drawing.Size(1091, 506);
            this.txtLogFile.TabIndex = 3;
            this.txtLogFile.TabStop = false;
            this.txtLogFile.Text = "logs";
            this.txtLogFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(919, 587);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 62);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 661);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtLogFile);
            this.Controls.Add(this.lblLogFileText);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogFileText;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Button btnClose;
    }
}