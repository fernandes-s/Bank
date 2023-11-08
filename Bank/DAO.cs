using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Bank
{
        internal class DAO
        //DAO = Data access Object
        {
            SqlConnection con;
            public DAO()
            {
                //provided by the using System.Configutarion
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString);
            }

            public SqlConnection OpenCon()
            {
                //ConnectionState comes from the Using.Data
                if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                {
                    con.Open();
                }
                return con;
            }

            public void CloseCon()
            {
                if (con != null)
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
