using prjAdoDotNetDemo.Models;
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
    public partial class FrmCustomerList : Form
    {
        private List<int> _listPK;
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCustomerEditor f = new FrmCustomerEditor();
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            { 
                (new CCustomerManager()).create(f.customer);
                MessageBox.Show("新增資料成功");
                displayCustomers("SELECT * FROM tCustomer", false);
            }
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            displayCustomers("SELECT * FROM tCustomer", false);

            //listBox1.Items.Clear();
            //string sql = "SELECT * FROM tCustomer";
            //List<CCustomer> list = (new CCustomerManager()).getBySql(sql);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    listBox1.Items.Add(list[i].fName + "\t" + list[i].fPhone);
            //}
        }

        private void displayCustomers(string sql, bool isKey)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            if (isKey)
                cmd.Parameters.Add(new SqlParameter("K_QRY", (object)("%" + textBox1.Text.Trim()) + "%"));
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            _listPK = new List<int>();
            while (reader.Read())
            {
                _listPK.Add(Convert.ToInt32(reader["fId"]));
                listBox1.Items.Add(reader["fName"].ToString() + "\t" + reader["fPhone"].ToString());
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            int pk = _listPK[listBox1.SelectedIndex];
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM tCustomer WHERE fId = "+ pk.ToString();
            cmd.ExecuteNonQuery();

            con.Close();
            displayCustomers("SELECT * FROM tCustomer", false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editCustomer();
        }

        private void editCustomer()
        {
            if (listBox1.SelectedIndex < 0)
                return;
            int pk = _listPK[listBox1.SelectedIndex];
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tCustomer WHERE fId = @K_FID";
            cmd.Parameters.Add(new SqlParameter("K_FID", (object) pk));
            SqlDataReader reader = cmd.ExecuteReader();
            CCustomer x = null;
            if (reader.Read())
            {
                x = new CCustomer();
                x.fId = Convert.ToInt32(reader["fId"]);
                x.fName = reader["fName"].ToString();
                x.fPhone = reader["fPhone"].ToString();
                x.fEmail = reader["fEmail"].ToString();
                x.fAddress = reader["fAddress"].ToString();
                x.fPassword = reader["fPassword"].ToString();
            }

            con.Close();
            if (x == null)
                return;
            FrmCustomerEditor f = new FrmCustomerEditor();
            f.customer = x;
            f.ShowDialog();

            if (f.isOK == DialogResult.OK)
            {
                (new CCustomerManager()).update(f.customer);
                displayCustomers("SELECT * FROM tCustomer", false);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            editCustomer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tCustomer WHERE ";
            sql += "fName LIKE @K_QRY";
            sql += " OR fPhone LIKE @K_QRY";
            sql += " OR fEmail LIKE @K_QRY";
            sql += " OR fAddress LIKE @K_QRY";
            displayCustomers(sql, true);
        }
    }
}
