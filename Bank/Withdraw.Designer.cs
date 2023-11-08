namespace Bank
{
    partial class Withdraw
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
            this.gpoWithdraw = new System.Windows.Forms.GroupBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.cboAccNum = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblaccn = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gpoWithdraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpoWithdraw
            // 
            this.gpoWithdraw.Controls.Add(this.txtAmt);
            this.gpoWithdraw.Controls.Add(this.txtBal);
            this.gpoWithdraw.Controls.Add(this.cboAccNum);
            this.gpoWithdraw.Controls.Add(this.btnClose);
            this.gpoWithdraw.Controls.Add(this.btnSubmit);
            this.gpoWithdraw.Controls.Add(this.lblAmount);
            this.gpoWithdraw.Controls.Add(this.lblBal);
            this.gpoWithdraw.Controls.Add(this.lblDisplay);
            this.gpoWithdraw.Controls.Add(this.lblaccn);
            this.gpoWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoWithdraw.ForeColor = System.Drawing.Color.Coral;
            this.gpoWithdraw.Location = new System.Drawing.Point(13, 13);
            this.gpoWithdraw.Name = "gpoWithdraw";
            this.gpoWithdraw.Size = new System.Drawing.Size(775, 425);
            this.gpoWithdraw.TabIndex = 2;
            this.gpoWithdraw.TabStop = false;
            this.gpoWithdraw.Text = "Withdraw";
            this.gpoWithdraw.Enter += new System.EventHandler(this.gpoWithdraw_Enter);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(154, 141);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(252, 30);
            this.txtAmt.TabIndex = 3;
            // 
            // txtBal
            // 
            this.txtBal.Location = new System.Drawing.Point(154, 104);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(252, 30);
            this.txtBal.TabIndex = 2;
            // 
            // cboAccNum
            // 
            this.cboAccNum.FormattingEnabled = true;
            this.cboAccNum.Location = new System.Drawing.Point(154, 30);
            this.cboAccNum.Name = "cboAccNum";
            this.cboAccNum.Size = new System.Drawing.Size(252, 33);
            this.cboAccNum.TabIndex = 1;
            this.cboAccNum.SelectedIndexChanged += new System.EventHandler(this.cboAccNum_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 189);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(165, 48);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 141);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(80, 25);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Location = new System.Drawing.Point(7, 104);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(83, 25);
            this.lblBal.TabIndex = 2;
            this.lblBal.Text = "Balance";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Yellow;
            this.lblDisplay.Location = new System.Drawing.Point(7, 67);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(399, 25);
            this.lblDisplay.TabIndex = 1;
            // 
            // lblaccn
            // 
            this.lblaccn.AutoSize = true;
            this.lblaccn.Location = new System.Drawing.Point(7, 30);
            this.lblaccn.Name = "lblaccn";
            this.lblaccn.Size = new System.Drawing.Size(130, 25);
            this.lblaccn.TabIndex = 0;
            this.lblaccn.Text = "Account Num";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpoWithdraw);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.gpoWithdraw.ResumeLayout(false);
            this.gpoWithdraw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoWithdraw;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.ComboBox cboAccNum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblaccn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}