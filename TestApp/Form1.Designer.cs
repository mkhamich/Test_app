namespace TestApp
{
    partial class DispenceCountForm
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
            this.btnAcetamPlus = new System.Windows.Forms.Button();
            this.btnOxyPlus = new System.Windows.Forms.Button();
            this.btnIbuprPlus = new System.Windows.Forms.Button();
            this.txtAcetamin = new System.Windows.Forms.TextBox();
            this.txtOxyCotin = new System.Windows.Forms.TextBox();
            this.txtIbuprofen = new System.Windows.Forms.TextBox();
            this.txtAcetaminCount = new System.Windows.Forms.TextBox();
            this.txtIbuprCount = new System.Windows.Forms.TextBox();
            this.txtOxyCotinCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDrug = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnViewLogForm = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAcetamMinus = new System.Windows.Forms.Button();
            this.btnOxyMinus = new System.Windows.Forms.Button();
            this.btnIbuprMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcetamPlus
            // 
            this.btnAcetamPlus.Location = new System.Drawing.Point(705, 146);
            this.btnAcetamPlus.Name = "btnAcetamPlus";
            this.btnAcetamPlus.Size = new System.Drawing.Size(110, 50);
            this.btnAcetamPlus.TabIndex = 0;
            this.btnAcetamPlus.Text = "+";
            this.btnAcetamPlus.UseVisualStyleBackColor = true;
            this.btnAcetamPlus.Click += new System.EventHandler(this.btnAcetamPlus_Click);
            // 
            // btnOxyPlus
            // 
            this.btnOxyPlus.Location = new System.Drawing.Point(705, 217);
            this.btnOxyPlus.Name = "btnOxyPlus";
            this.btnOxyPlus.Size = new System.Drawing.Size(110, 50);
            this.btnOxyPlus.TabIndex = 1;
            this.btnOxyPlus.Text = "+";
            this.btnOxyPlus.UseVisualStyleBackColor = true;
            this.btnOxyPlus.Click += new System.EventHandler(this.btnOxyPlus_Click);
            // 
            // btnIbuprPlus
            // 
            this.btnIbuprPlus.Location = new System.Drawing.Point(705, 290);
            this.btnIbuprPlus.Name = "btnIbuprPlus";
            this.btnIbuprPlus.Size = new System.Drawing.Size(110, 50);
            this.btnIbuprPlus.TabIndex = 2;
            this.btnIbuprPlus.Text = "+";
            this.btnIbuprPlus.UseVisualStyleBackColor = true;
            this.btnIbuprPlus.Click += new System.EventHandler(this.btnIbuprPlus_Click);
            // 
            // txtAcetamin
            // 
            this.txtAcetamin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAcetamin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAcetamin.Enabled = false;
            this.txtAcetamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcetamin.Location = new System.Drawing.Point(315, 147);
            this.txtAcetamin.Multiline = true;
            this.txtAcetamin.Name = "txtAcetamin";
            this.txtAcetamin.ReadOnly = true;
            this.txtAcetamin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAcetamin.Size = new System.Drawing.Size(300, 50);
            this.txtAcetamin.TabIndex = 3;
            this.txtAcetamin.Text = "Acetaminophen";
            this.txtAcetamin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOxyCotin
            // 
            this.txtOxyCotin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtOxyCotin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtOxyCotin.Enabled = false;
            this.txtOxyCotin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOxyCotin.Location = new System.Drawing.Point(315, 218);
            this.txtOxyCotin.Multiline = true;
            this.txtOxyCotin.Name = "txtOxyCotin";
            this.txtOxyCotin.ReadOnly = true;
            this.txtOxyCotin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOxyCotin.Size = new System.Drawing.Size(300, 50);
            this.txtOxyCotin.TabIndex = 4;
            this.txtOxyCotin.Text = "OxyCotin";
            this.txtOxyCotin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIbuprofen
            // 
            this.txtIbuprofen.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIbuprofen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtIbuprofen.Enabled = false;
            this.txtIbuprofen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIbuprofen.Location = new System.Drawing.Point(315, 291);
            this.txtIbuprofen.Multiline = true;
            this.txtIbuprofen.Name = "txtIbuprofen";
            this.txtIbuprofen.ReadOnly = true;
            this.txtIbuprofen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIbuprofen.Size = new System.Drawing.Size(300, 50);
            this.txtIbuprofen.TabIndex = 5;
            this.txtIbuprofen.Text = "Ibuprofen";
            this.txtIbuprofen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcetaminCount
            // 
            this.txtAcetaminCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAcetaminCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAcetaminCount.Enabled = false;
            this.txtAcetaminCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcetaminCount.Location = new System.Drawing.Point(78, 145);
            this.txtAcetaminCount.Multiline = true;
            this.txtAcetaminCount.Name = "txtAcetaminCount";
            this.txtAcetaminCount.ReadOnly = true;
            this.txtAcetaminCount.Size = new System.Drawing.Size(150, 50);
            this.txtAcetaminCount.TabIndex = 6;
            this.txtAcetaminCount.Text = "0";
            this.txtAcetaminCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIbuprCount
            // 
            this.txtIbuprCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIbuprCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtIbuprCount.Enabled = false;
            this.txtIbuprCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIbuprCount.Location = new System.Drawing.Point(78, 290);
            this.txtIbuprCount.Multiline = true;
            this.txtIbuprCount.Name = "txtIbuprCount";
            this.txtIbuprCount.ReadOnly = true;
            this.txtIbuprCount.Size = new System.Drawing.Size(150, 50);
            this.txtIbuprCount.TabIndex = 7;
            this.txtIbuprCount.Text = "0";
            this.txtIbuprCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOxyCotinCount
            // 
            this.txtOxyCotinCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOxyCotinCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtOxyCotinCount.Enabled = false;
            this.txtOxyCotinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOxyCotinCount.Location = new System.Drawing.Point(78, 217);
            this.txtOxyCotinCount.Multiline = true;
            this.txtOxyCotinCount.Name = "txtOxyCotinCount";
            this.txtOxyCotinCount.ReadOnly = true;
            this.txtOxyCotinCount.Size = new System.Drawing.Size(150, 50);
            this.txtOxyCotinCount.TabIndex = 8;
            this.txtOxyCotinCount.Text = "0";
            this.txtOxyCotinCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(103, 81);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(103, 37);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "Count";
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrug.Location = new System.Drawing.Point(388, 81);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(87, 37);
            this.lblDrug.TabIndex = 10;
            this.lblDrug.Text = "Drug";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(761, 81);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(107, 37);
            this.lblAction.TabIndex = 11;
            this.lblAction.Text = "Action";
            // 
            // btnViewLogForm
            // 
            this.btnViewLogForm.Location = new System.Drawing.Point(78, 467);
            this.btnViewLogForm.Name = "btnViewLogForm";
            this.btnViewLogForm.Size = new System.Drawing.Size(220, 60);
            this.btnViewLogForm.TabIndex = 12;
            this.btnViewLogForm.Text = "View Log Record";
            this.btnViewLogForm.UseVisualStyleBackColor = true;
            this.btnViewLogForm.Click += new System.EventHandler(this.btnViewLogForm_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(395, 467);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(220, 60);
            this.btnResetAll.TabIndex = 13;
            this.btnResetAll.Text = "Reset All Count";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(705, 467);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit Counter";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAcetamMinus
            // 
            this.btnAcetamMinus.Location = new System.Drawing.Point(815, 146);
            this.btnAcetamMinus.Name = "btnAcetamMinus";
            this.btnAcetamMinus.Size = new System.Drawing.Size(110, 50);
            this.btnAcetamMinus.TabIndex = 15;
            this.btnAcetamMinus.Text = "-";
            this.btnAcetamMinus.UseVisualStyleBackColor = true;
            this.btnAcetamMinus.Click += new System.EventHandler(this.btnAcetamMinus_Click);
            // 
            // btnOxyMinus
            // 
            this.btnOxyMinus.Location = new System.Drawing.Point(815, 217);
            this.btnOxyMinus.Name = "btnOxyMinus";
            this.btnOxyMinus.Size = new System.Drawing.Size(110, 50);
            this.btnOxyMinus.TabIndex = 16;
            this.btnOxyMinus.Text = "-";
            this.btnOxyMinus.UseVisualStyleBackColor = true;
            this.btnOxyMinus.Click += new System.EventHandler(this.btnOxyMinus_Click);
            // 
            // btnIbuprMinus
            // 
            this.btnIbuprMinus.Location = new System.Drawing.Point(815, 290);
            this.btnIbuprMinus.Name = "btnIbuprMinus";
            this.btnIbuprMinus.Size = new System.Drawing.Size(110, 50);
            this.btnIbuprMinus.TabIndex = 17;
            this.btnIbuprMinus.Text = "-";
            this.btnIbuprMinus.UseVisualStyleBackColor = true;
            this.btnIbuprMinus.Click += new System.EventHandler(this.btnIbuprMinus_Click);
            // 
            // DispenceCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 618);
            this.Controls.Add(this.btnIbuprMinus);
            this.Controls.Add(this.btnOxyMinus);
            this.Controls.Add(this.btnAcetamMinus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnViewLogForm);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblDrug);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtOxyCotinCount);
            this.Controls.Add(this.txtIbuprCount);
            this.Controls.Add(this.txtAcetaminCount);
            this.Controls.Add(this.txtIbuprofen);
            this.Controls.Add(this.txtOxyCotin);
            this.Controls.Add(this.txtAcetamin);
            this.Controls.Add(this.btnAcetamPlus);
            this.Controls.Add(this.btnIbuprPlus);
            this.Controls.Add(this.btnOxyPlus);
            this.Name = "DispenceCountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispence counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.DispenceCountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOxyPlus;
        private System.Windows.Forms.Button btnIbuprPlus;
        private System.Windows.Forms.Button btnAcetamPlus;
        private System.Windows.Forms.TextBox txtAcetamin;
        private System.Windows.Forms.TextBox txtOxyCotin;
        private System.Windows.Forms.TextBox txtIbuprofen;
        private System.Windows.Forms.TextBox txtAcetaminCount;
        private System.Windows.Forms.TextBox txtIbuprCount;
        private System.Windows.Forms.TextBox txtOxyCotinCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnViewLogForm;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAcetamMinus;
        private System.Windows.Forms.Button btnOxyMinus;
        private System.Windows.Forms.Button btnIbuprMinus;
    }
}

