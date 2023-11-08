using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        AddData ad = new AddData();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(Counties));
            cboAccType.DataSource = Enum.GetValues(typeof(AccType));
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string dob = dtpDOB.Text;
            string cy = cboCounty.SelectedItem.ToString();
            string ge = "Male";
            if(rdoFemale.Checked)
            {
                ge = "Female";
            }
            decimal amt = decimal.Parse(txtDeposit.Text);
            string acty = cboAccType.SelectedItem.ToString();

            ad.AddNewAccount(fn, sn, dob, cy, ge, amt, acty);
            MessageBox.Show("Data Added");

            txtFn.Clear();
            txtSn.Clear();
            txtDeposit.Clear();

        }
    }
}
