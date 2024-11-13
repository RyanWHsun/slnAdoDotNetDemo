using prjAdoDotNetDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdoDotNetDemo.Views
{
    public partial class FrmOrder : Form
    {
        private CRoom _selected;
        private List<CDetail> _list = new List<CDetail>();
        int _position = -1;
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Button x = new Button();
                x.Text = "OK";
                x.Width = 80;
                x.Height = 50;
                x.BackColor = Color.Black;
                x.ForeColor = Color.White;
                x.Click += this.btnOK_click;
                flowLayoutPanel1.Controls.Add(x);
            }

        }

        private void btnOK_click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tProduct WHERE ";
            sql += "fName LIKE @K_KEYWORD";
            sql += " OR fMemo LIKE @K_KEYWORD";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", (object)("%" + fieldBox1.filedValue + "%")));
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                CRoom room = new CRoom();
                room.fId = Convert.ToInt32(row["fid"]);
                room.fName = row["fName"].ToString();
                room.fQty = Convert.ToInt32(row["fQty"]);
                room.fPrice = Convert.ToDecimal(row["fPrice"]);
                room.fCost = Convert.ToDecimal(row["fCost"]);
                room.fMemo = row["fMemo"].ToString();
                if (row["fImage"] != DBNull.Value)
                    room.fImage = (byte[])row["fImage"];

                RoomBox x = new RoomBox();
                x.room = room;
                x.orderRoom += this.orderRoom;
                flowLayoutPanel1.Controls.Add(x);
            }
        }
        private void orderRoom(CRoom p)
        {
            _selected = p;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;
            dataGridView1.DataSource = null;
            CDetail d = new CDetail();
            d.房間編號 = _selected.fId;
            d.房型 = _selected.fName;
            d.數量 = Convert.ToInt32(fbCount.filedValue);
            d.金額 = d.數量 * _selected.fPrice;
            d.入住日期 = fbDate.filedValue;
            _list.Add(d);

            decimal pay = 0;
            foreach (CDetail x in _list)
                pay += x.金額;
            lblPayment.Text = pay.ToString();
            dataGridView1.DataSource = _list;
            resetGridStyle();
        }
        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = dataGridView1.Width - dataGridView1.RowHeadersWidth - 200 - 120 - 80;

            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.FromArgb(255, 234, 241);
                if (isColorChanged)
                {
                    r.DefaultCellStyle.BackColor = Color.FromArgb(252, 244, 231);
                }
            }
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            fbDate.filedValue = DateTime.Today.ToString("yyyy/MM/dd");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_list == null)
                return;
            if (_list.Count == 0)
                return;

            string sql = "INSERT INTO tOrder (";
            sql += "fDate,";
            sql += "fCustomerId";
            sql += ")VALUES(";
            sql += "'" + DateTime.Now.ToString("yyyyMMddHHmmss") + "',";
            sql += "1)";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();
            SqlTransaction ts = con.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = ts;
            try
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                sql = "SELECT MAX(fId) AS OrderId FROM tOrder";
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                int orderId = 0;
                if (reader.Read())
                {
                    orderId = (int)reader["OrderId"];
                }
                reader.Close();
                foreach (CDetail d in _list)
                {
                    sql = "INSERT INTO tDetail (";
                    sql += "fOrderId,";
                    sql += "fRoomId,";
                    sql += "fCount,";
                    sql += "fPayment,";
                    sql += "fDateIn";
                    sql += ")VALUES(";
                    sql += orderId.ToString() + ",";
                    sql += d.房間編號.ToString() + ",";
                    sql += d.數量.ToString() + ",";
                    sql += d.金額.ToString() + ",";
                    sql += "'" + d.入住日期 + "')";

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                ts.Commit();
                dataGridView1.DataSource = null;
                lblPayment.Text = "0";
                fbCount.filedValue = "1";
                fbDate.filedValue = DateTime.Today.ToString("yyyy/MM/dd");
                _list = new List<CDetail>();
                _selected = null;
            }
            catch
            {
                ts.Rollback();
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            _list.RemoveAt(_position);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _list;
            resetGridStyle();
        }
    }
}
