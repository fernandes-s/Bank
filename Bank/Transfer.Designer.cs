namespace Bank
{
    partial class Transfer
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
            this.gpoTransfer = new System.Windows.Forms.GroupBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtBalFrom = new System.Windows.Forms.TextBox();
            this.cboAccFrom = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblAccFrom = new System.Windows.Forms.Label();
            this.lblAccTo = new System.Windows.Forms.Label();
            this.cboAccTo = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtBalTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpoTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpoTransfer
            // 
            this.gpoTransfer.Controls.Add(this.txtBalTo);
            this.gpoTransfer.Controls.Add(this.label1);
            this.gpoTransfer.Controls.Add(this.lblTo);
            this.gpoTransfer.Controls.Add(this.cboAccTo);
            this.gpoTransfer.Controls.Add(this.lblAccTo);
            this.gpoTransfer.Controls.Add(this.txtAmt);
            this.gpoTransfer.Controls.Add(this.txtBalFrom);
            this.gpoTransfer.Controls.Add(this.cboAccFrom);
            this.gpoTransfer.Controls.Add(this.btnClose);
            this.gpoTransfer.Controls.Add(this.btnTransfer);
            this.gpoTransfer.Controls.Add(this.lblAmount);
            this.gpoTransfer.Controls.Add(this.lblBal);
            this.gpoTransfer.Controls.Add(this.lblFrom);
            this.gpoTransfer.Controls.Add(this.lblAccFrom);
            this.gpoTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoTransfer.ForeColor = System.Drawing.Color.Coral;
            this.gpoTransfer.Location = new System.Drawing.Point(13, 13);
            this.gpoTransfer.Name = "gpoTransfer";
            this.gpoTransfer.Size = new System.Drawing.Size(775, 425);
            this.gpoTransfer.TabIndex = 2;
            this.gpoTransfer.TabStop = false;
            this.gpoTransfer.Text = "Transfer";
            this.gpoTransfer.Enter += new System.EventHandler(this.gpoTransfer_Enter);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(154, 141);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(252, 30);
            this.txtAmt.TabIndex = 3;
            // 
            // txtBalFrom
            // 
            this.txtBalFrom.Location = new System.Drawing.Point(154, 104);
            this.txtBalFrom.Name = "txtBalFrom";
            this.txtBalFrom.Size = new System.Drawing.Size(252, 30);
            this.txtBalFrom.TabIndex = 2;
            // 
            // cboAccFrom
            // 
            this.cboAccFrom.FormattingEnabled = true;
            this.cboAccFrom.Location = new System.Drawing.Point(154, 30);
            this.cboAccFrom.Name = "cboAccFrom";
            this.cboAccFrom.Size = new System.Drawing.Size(252, 33);
            this.cboAccFrom.TabIndex = 1;
            this.cboAccFrom.SelectedIndexChanged += new System.EventHandler(this.cboAccFrom_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(12, 351);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(165, 48);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
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
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.Color.Yellow;
            this.lblFrom.Location = new System.Drawing.Point(7, 67);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(399, 25);
            this.lblFrom.TabIndex = 1;
            // 
            // lblAccFrom
            // 
            this.lblAccFrom.AutoSize = true;
            this.lblAccFrom.Location = new System.Drawing.Point(7, 30);
            this.lblAccFrom.Name = "lblAccFrom";
            this.lblAccFrom.Size = new System.Drawing.Size(134, 25);
            this.lblAccFrom.TabIndex = 0;
            this.lblAccFrom.Text = "Account From";
            // 
            // lblAccTo
            // 
            this.lblAccTo.AutoSize = true;
            this.lblAccTo.Location = new System.Drawing.Point(7, 185);
            this.lblAccTo.Name = "lblAccTo";
            this.lblAccTo.Size = new System.Drawing.Size(113, 25);
            this.lblAccTo.TabIndex = 6;
            this.lblAccTo.Text = "Account To";
            // 
            // cboAccTo
            // 
            this.cboAccTo.FormattingEnabled = true;
            this.cboAccTo.Location = new System.Drawing.Point(154, 185);
            this.cboAccTo.Name = "cboAccTo";
            this.cboAccTo.Size = new System.Drawing.Size(252, 33);
            this.cboAccTo.TabIndex = 7;
            this.cboAccTo.SelectedIndexChanged += new System.EventHandler(this.cboAccTo_SelectedIndexChanged);
            // 
            // lblTo
            // 
            this.lblTo.BackColor = System.Drawing.Color.Yellow;
            this.lblTo.Location = new System.Drawing.Point(7, 236);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(399, 25);
            this.lblTo.TabIndex = 8;
            // 
            // txtBalTo
            // 
            this.txtBalTo.Location = new System.Drawing.Point(154, 272);
            this.txtBalTo.Name = "txtBalTo";
            this.txtBalTo.Size = new System.Drawing.Size(252, 30);
            this.txtBalTo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Balance";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpoTransfer);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.gpoTransfer.ResumeLayout(false);
            this.gpoTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoTransfer;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtBalFrom;
        private System.Windows.Forms.ComboBox cboAccFrom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblAccFrom;
        private System.Windows.Forms.Label lblAccTo;
        private System.Windows.Forms.ComboBox cboAccTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtBalTo;
        private System.Windows.Forms.Label label1;
    }
}