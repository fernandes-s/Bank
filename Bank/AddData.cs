using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bank
{
    internal class AddData : DAO
    {
        /// static key word provides memory at run time
        /// void is only gona execute someting and not return any value
        public void AddNewAccount(string fn, string sn, string dob, string cy, string ge, decimal amt, string acty)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddAcc";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@ge", ge);
            cmd.Parameters.AddWithValue("@bal", amt);
            cmd.Parameters.AddWithValue("@acty", acty);

            cmd.ExecuteNonQuery();
            CloseCon();
        }
        
    }
}
