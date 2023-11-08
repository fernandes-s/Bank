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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            Account ac  = new Account();
            ac.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();
            d.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer t = new Transfer();
            t.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Transactions ta = new Transactions();
            ta.ShowDialog();
        }
    }
}
