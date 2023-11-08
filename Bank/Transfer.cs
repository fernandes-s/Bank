using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bank
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        DAO dao = new DAO();
        SqlDataReader dr;

        private void gpoTransfer_Enter(object sender, EventArgs e)
        {

        }


        private void Transfer_Load(object sender, EventArgs e)
        {
            PopCombo();

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            FundsFrom();
            FundsTo();
        }

        void PopCombo()
        {
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspPopCombo";
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string acc = dr["AccNum"].ToString();
                cboAccFrom.Items.Add(acc);
                cboAccTo.Items.Add(acc);
            }
            dao.CloseCon();
        }

        private void cboAccFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string accNum = cboAccFrom.SelectedItem.ToString();
            //GetData(accNum);
            string accNum = cboAccFrom.SelectedItem.ToString();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetBal";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNo", accNum);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string fn = dr["FirstName"].ToString();
                string sn = dr["Surname"].ToString();
                string cy = dr["County"].ToString();
                string bal = dr["Balance"].ToString();
                lblFrom.Text = fn + " " + sn + " from " + cy;
                txtBalFrom.Text = bal;
            }
            dao.CloseCon();

        }

        private void cboAccTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string accNum = cboAccTo.SelectedItem.ToString();
            //GetData(accNum);
            string accNum = cboAccTo.SelectedItem.ToString();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetBal";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNo", accNum);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string fn = dr["FirstName"].ToString();
                string sn = dr["Surname"].ToString();
                string cy = dr["County"].ToString();
                string bal = dr["Balance"].ToString();
                lblTo.Text = fn + " " + sn + " from " + cy;
                txtBalTo.Text = bal;
            }
            dao.CloseCon();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GetData(string accn)
        {

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetBal";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNo", accn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string fn = dr["FirstName"].ToString();
                string sn = dr["Surname"].ToString();
                string cy = dr["County"].ToString();
                string bal = dr["Balance"].ToString();
                lblFrom.Text = fn + " " + sn + " from " + cy;
                lblTo.Text = fn + " " + sn + " from " + cy;
                txtBalFrom.Text = bal;
                txtBalTo.Text = bal;
            }
            dao.CloseCon();
        }


        void FundsFrom()
        {
            string accNum = cboAccFrom.SelectedItem.ToString();
            decimal bal = decimal.Parse(txtBalFrom.Text);
            decimal amt = decimal.Parse(txtAmt.Text);
            decimal nb = bal;

            if (amt < bal)
            {
                nb = bal - amt;
                MessageBox.Show("Transaction Completed! \nYou Withdrew: $" + amt + "\nYour new balance is: $" + nb, "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Insuficient funds! \nWithdraw of: $ " + amt + " denied." + "\nYour max withdraw is: $" + nb, "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspUpdateBalance";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNo", accNum);
            cmd.Parameters.AddWithValue("@nb", nb);

            cmd.ExecuteNonQuery();
            dao.CloseCon();

            txtBalFrom.Clear();
        }


        void FundsTo()
        {
            string accNum = cboAccTo.SelectedItem.ToString();
            decimal bal = decimal.Parse(txtBalTo.Text);
            decimal amt = decimal.Parse(txtAmt.Text);

            decimal nb = bal + amt;

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspUpdateBalance";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNo", accNum);
            cmd.Parameters.AddWithValue("@nb", nb);

            cmd.ExecuteNonQuery();
            dao.CloseCon();

            MessageBox.Show("Money Added! \nYou deposited: $" + amt + "\nYour new balance is: $" + nb, "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtAmt.Clear();
            txtBalTo.Clear();
        }

    }
}
