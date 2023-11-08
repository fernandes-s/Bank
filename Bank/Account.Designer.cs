namespace Bank
{
    partial class Account
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
            this.gpoNewAcc = new System.Windows.Forms.GroupBox();
            this.lblfn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.cboAccType = new System.Windows.Forms.ComboBox();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gpoNewAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpoNewAcc
            // 
            this.gpoNewAcc.Controls.Add(this.btnClose);
            this.gpoNewAcc.Controls.Add(this.btnAddAcc);
            this.gpoNewAcc.Controls.Add(this.cboAccType);
            this.gpoNewAcc.Controls.Add(this.txtDeposit);
            this.gpoNewAcc.Controls.Add(this.rdoFemale);
            this.gpoNewAcc.Controls.Add(this.rdoMale);
            this.gpoNewAcc.Controls.Add(this.cboCounty);
            this.gpoNewAcc.Controls.Add(this.dtpDOB);
            this.gpoNewAcc.Controls.Add(this.txtSn);
            this.gpoNewAcc.Controls.Add(this.txtFn);
            this.gpoNewAcc.Controls.Add(this.label6);
            this.gpoNewAcc.Controls.Add(this.label5);
            this.gpoNewAcc.Controls.Add(this.label4);
            this.gpoNewAcc.Controls.Add(this.label3);
            this.gpoNewAcc.Controls.Add(this.label2);
            this.gpoNewAcc.Controls.Add(this.label1);
            this.gpoNewAcc.Controls.Add(this.lblfn);
            this.gpoNewAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoNewAcc.ForeColor = System.Drawing.Color.Coral;
            this.gpoNewAcc.Location = new System.Drawing.Point(13, 13);
            this.gpoNewAcc.Name = "gpoNewAcc";
            this.gpoNewAcc.Size = new System.Drawing.Size(775, 425);
            this.gpoNewAcc.TabIndex = 0;
            this.gpoNewAcc.TabStop = false;
            this.gpoNewAcc.Text = "New Account";
            // 
            // lblfn
            // 
            this.lblfn.AutoSize = true;
            this.lblfn.Location = new System.Drawing.Point(7, 30);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(106, 25);
            this.lblfn.TabIndex = 0;
            this.lblfn.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "County";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Deposit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Account Type";
            // 
            // txtFn
            // 
            this.txtFn.Location = new System.Drawing.Point(154, 32);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(252, 30);
            this.txtFn.TabIndex = 7;
            // 
            // txtSn
            // 
            this.txtSn.Location = new System.Drawing.Point(154, 68);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(252, 30);
            this.txtSn.TabIndex = 8;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(154, 104);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(252, 30);
            this.dtpDOB.TabIndex = 9;
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(154, 141);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(252, 33);
            this.cboCounty.TabIndex = 10;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(154, 183);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(76, 29);
            this.rdoMale.TabIndex = 11;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(308, 183);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(98, 29);
            this.rdoFemale.TabIndex = 12;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(154, 221);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(252, 30);
            this.txtDeposit.TabIndex = 13;
            // 
            // cboAccType
            // 
            this.cboAccType.FormattingEnabled = true;
            this.cboAccType.Location = new System.Drawing.Point(154, 263);
            this.cboAccType.Name = "cboAccType";
            this.cboAccType.Size = new System.Drawing.Size(252, 33);
            this.cboAccType.TabIndex = 14;
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(12, 331);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(165, 48);
            this.btnAddAcc.TabIndex = 15;
            this.btnAddAcc.Text = "Add Account";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 48);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpoNewAcc);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.gpoNewAcc.ResumeLayout(false);
            this.gpoNewAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoNewAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cboAccType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddAcc;
    }
}