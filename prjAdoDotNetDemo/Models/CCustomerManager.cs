using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdoDotNetDemo.Models
{
    public class CCustomerManager
    {
        public void create(CCustomer p)
        {
            string sql;

            sql = "INSERT INTO tCustomer (";
            sql += "fName,";
            sql += "fPhone,";
            sql += "fEmail,";
            sql += "fAddress,";
            sql += "fPassword";
            sql += ")";

            sql += "VALUES (";
            //sql += "'" + p.fName + "',";
            //sql += "'" + p.fPhone + "',";
            //sql += "'" + p.fEmail + "',";
            //sql += "'" + p.fAddress + "',";
            //sql += "'" + p.fPassword + "'";
            sql += "@K_FNAME,";
            sql += "@K_FPHONE,";
            sql += "@K_FEMAIL,";
            sql += "@K_FADDRESS,";
            sql += "@K_FPASSWORD";
            sql += ")";

            SqlParameter pName = new SqlParameter("K_FNAME", (object)p.fName);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(pName);
            cmd.Parameters.Add(new SqlParameter("K_FPHONE", (object)p.fPhone));
            cmd.Parameters.Add(new SqlParameter("K_FEMAIL", (object)p.fEmail));
            cmd.Parameters.Add(new SqlParameter("K_FADDRESS", (object)p.fAddress));
            cmd.Parameters.Add(new SqlParameter("K_FPASSWORD", (object)p.fPassword));
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void update(CCustomer p)
        {
            string sql;

            sql = "UPDATE tCustomer ";
            sql += "SET ";
            sql += "fName = @K_FNAME,";
            sql += "fPhone = @K_FPHONE,";
            sql += "fEmail = @K_FEMAIL,";
            sql += "fAddress = @K_FADDRESS,";
            sql += "fPassword = @K_FPASSWORD";
            sql += " WHERE fId = @K_FID";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_FNAME", (object)p.fName));
            cmd.Parameters.Add(new SqlParameter("K_FPHONE", (object)p.fPhone));
            cmd.Parameters.Add(new SqlParameter("K_FEMAIL", (object)p.fEmail));
            cmd.Parameters.Add(new SqlParameter("K_FADDRESS", (object)p.fAddress));
            cmd.Parameters.Add(new SqlParameter("K_FPASSWORD", (object)p.fPassword));
            cmd.Parameters.Add(new SqlParameter("K_FID", (object)p.fId));
            cmd.ExecuteNonQuery();

            con.Close();
        }

        //public List<CCustomer> getBySql(string sql)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = sql;

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    List<CCustomer> list = new List<CCustomer>();
        //    while (reader.Read()) 
        //    {
        //        CCustomer x = new CCustomer();
        //        x.fId = Convert.ToInt32(reader["fId"]);
        //        x.fName = reader["fName"].ToString();
        //        x.fPhone = reader["fPhone"].ToString();
        //        x.fEmail = reader["fEmail"].ToString();
        //        x.fAddress = reader["fAddress"].ToString();
        //        x.fPassword = reader["fPassword"].ToString();
        //        list.Add(x);
        //    }
        //    con.Close();
        //    return list;
        //}


    }
}
