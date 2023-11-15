namespace Bank
{
    partial class Transactions
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAllAcc = new System.Windows.Forms.Button();
            this.btnAccAbove = new System.Windows.Forms.Button();
            this.cboGen = new System.Windows.Forms.ComboBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAllTran = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 189);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(775, 249);
            this.dgv.TabIndex = 0;
            // 
            // btnAllAcc
            // 
            this.btnAllAcc.Location = new System.Drawing.Point(13, 46);
            this.btnAllAcc.Name = "btnAllAcc";
            this.btnAllAcc.Size = new System.Drawing.Size(122, 22);
            this.btnAllAcc.TabIndex = 1;
            this.btnAllAcc.Text = "All Accounts";
            this.btnAllAcc.UseVisualStyleBackColor = true;
            this.btnAllAcc.Click += new System.EventHandler(this.btnAllAcc_Click);
            // 
            // btnAccAbove
            // 
            this.btnAccAbove.Location = new System.Drawing.Point(292, 46);
            this.btnAccAbove.Name = "btnAccAbove";
            this.btnAccAbove.Size = new System.Drawing.Size(122, 22);
            this.btnAccAbove.TabIndex = 3;
            this.btnAccAbove.Text = "Acc Above";
            this.btnAccAbove.UseVisualStyleBackColor = true;
            this.btnAccAbove.Click += new System.EventHandler(this.btnAccAbove_Click);
            // 
            // cboGen
            // 
            this.cboGen.FormattingEnabled = true;
            this.cboGen.Location = new System.Drawing.Point(431, 46);
            this.cboGen.Name = "cboGen";
            this.cboGen.Size = new System.Drawing.Size(121, 24);
            this.cboGen.TabIndex = 4;
            this.cboGen.SelectedIndexChanged += new System.EventHandler(this.cboGen_SelectedIndexChanged);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(169, 47);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(100, 22);
            this.txtAmt.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(599, 48);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(122, 22);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAllTran
            // 
            this.btnAllTran.Location = new System.Drawing.Point(13, 75);
            this.btnAllTran.Name = "btnAllTran";
            this.btnAllTran.Size = new System.Drawing.Size(122, 23);
            this.btnAllTran.TabIndex = 7;
            this.btnAllTran.Text = "All Transactions";
            this.btnAllTran.UseVisualStyleBackColor = true;
            this.btnAllTran.Click += new System.EventHandler(this.btnAllTran_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAllTran);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.cboGen);
            this.Controls.Add(this.btnAccAbove);
            this.Controls.Add(this.btnAllAcc);
            this.Controls.Add(this.dgv);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAllAcc;
        private System.Windows.Forms.Button btnAccAbove;
        private System.Windows.Forms.ComboBox cboGen;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAllTran;
    }
}