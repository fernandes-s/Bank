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
    public partial class Withdraw : Form
    {
        SqlDataReader dr;
        DAO dao = new DAO();
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gpoWithdraw_Enter(object sender, EventArgs e)
        {

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
                cboAccNum.Items.Add(acc);
            }
            dao.CloseCon();


        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            PopCombo();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string accNum = cboAccNum.SelectedItem.ToString();
            decimal bal = decimal.Parse(txtBal.Text);
            decimal amt = decimal.Parse(txtAmt.Text);
            decimal nb = bal;

            if(amt < bal)
            {
                nb = bal - amt;
                MessageBox.Show("Transaction Completed! \nYou Withdrew: $" + amt + "\nYour new balance is: $" + nb, "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Insuficient funds! \nWithdraw of: $ " + amt +" denied." + "\nYour max withdraw is: $" + nb, "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspUpdateBalance";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@acNo", accNum);
            cmd.Parameters.AddWithValue("@nb", nb);

            cmd.ExecuteNonQuery();
            dao.CloseCon();


            txtAmt.Clear();
            txtBal.Clear();
        }

        private void cboAccNum_SelectedIndexChanged(object sender, EventArgs e)
        {

            string accNum = cboAccNum.SelectedItem.ToString();

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
                lblDisplay.Text = fn + " " + sn + " from " + cy;
                txtBal.Text = bal;
            }
            dao.CloseCon();


        }
    }
}
