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

namespace prjAdoDotNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = getInsertSql();
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("資料增新成功");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM tCustomer WHERE fName = 'Marco'";
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("資料刪除成功");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = getUpdateSql();
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("資料修改成功");
        }


        private string getInsertSql()
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
            sql += "'Marco', '0912345678', 'marco@gmail.com', 'Taipei', '1234'";
            sql += ")";

            return sql;
        }

        private string getUpdateSql()
        {
            string sql;

            sql = "UPDATE tCustomer ";
            sql += "SET ";
            sql += "fName = 'Selina',";
            sql += "fPhone = '092234567',";
            sql += "fEmail = 'selina@gmail.com',";
            sql += "fAddress = 'Taichung',";
            sql += "fPassword = '0000'";
            sql += "WHERE fName = 'Marco'";
            return sql;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = getSelectSql(keyword);

            SqlDataReader reader = cmd.ExecuteReader();
            string s = "查無資料";
            if (reader.Read())
            {
                s = reader["fName"].ToString();
                s += "\r\n" + reader["fPhone"].ToString();
            }

            con.Close();

            MessageBox.Show(s);
        }

        private string getSelectSql(string keyword)
        {
            string sql;
            sql = "SELECT * FROM tCustomer ";
            //sql += $"WHERE fName Like '%{textBox1.Text.Trim()}%'";
            sql += "WHERE fName Like '%" + keyword + "%'";
            return sql;
        }
    }
}
