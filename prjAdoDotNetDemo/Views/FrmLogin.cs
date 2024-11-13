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

namespace prjAdoDotNetDemo.Views
{
    public partial class FrmLogin : Form
    {
        private bool isClosed = true;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tCustomer WHERE";
            sql += " fEmail = @K_fEmail";
            sql += " AND fPassword = @K_PASSWORD";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_fEmail", (object)fieldBox1.filedValue));
            cmd.Parameters.Add(new SqlParameter("K_PASSWORD", (object)fieldBox2.filedValue));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                isClosed = false;
                Close();
            }
            else
                MessageBox.Show("帳號與密碼不符");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            fieldBox2.passwordMask = '*';
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClosed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isClosed = false;
            Application.Exit();
        }
    }
}
