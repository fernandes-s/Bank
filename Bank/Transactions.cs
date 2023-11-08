using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        DAO dao = new DAO();
        SqlDataAdapter da;
        DataTable dt;

        private void btnAllAcc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            LoadData();
            cboGen.DataSource = Enum.GetValues(typeof(Gen));
        }

        private void btnAccAbove_Click(object sender, EventArgs e)
        {
            decimal amt = decimal.Parse(txtAmt.Text);
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspAllAbove";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@amt", amt);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string gen = cboGen.SelectedItem.ToString();
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGen";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gen", gen);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
        }

        private void cboGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gen = cboGen.SelectedItem.ToString();
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGen";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gen", gen);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;
            dao.CloseCon();
        }
    }
}
