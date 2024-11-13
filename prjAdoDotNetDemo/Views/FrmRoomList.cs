using prjAdoDotNetDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdoDotNetDemo.Views
{
    public partial class FrmRoomList : Form
    {
        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        DataSet _ds = null;
        private int _position = -1;
        public FrmRoomList()
        {
            InitializeComponent();
        }
        private void FrmRoomList_Load(object sender, EventArgs e)
        {
            displayRoomBySql("SELECT * FROM tProduct", false);
        }

        private void displayRoomBySql(string sql, bool isKeyword)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            con.Open();
            _da = new SqlDataAdapter(sql, con);
            if (isKeyword)
            {
                _da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", (object)("%" +txtKeyword.Text + "%")));
            }
            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da;

            _ds = new DataSet();
            _da.Fill(_ds);
            con.Close();
            dataGridView1.DataSource = _ds.Tables[0];
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmRoomEditor f = new FrmRoomEditor();
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable; 
                DataRow row = dt.NewRow();
                row["fName"] = f.room.fName;
                row["fQty"] = f.room.fQty;
                row["fPrice"] = f.room.fPrice;
                row["fCost"] = f.room.fCost;
                row["fMemo"] = f.room.fMemo;
                row["fImage"] = f.room.fImage;
                dt.Rows.Add(row);
            }
        }

        private void FrmRoomList_FormClosed(object sender, FormClosedEventArgs e)
        {
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];
            CRoom x = new CRoom();
            if(row["fid"] != DBNull.Value)
                x.fId = Convert.ToInt32(row["fid"]);
            x.fName = row["fName"].ToString();
            x.fQty = Convert.ToInt32(row["fQty"]);
            x.fPrice = Convert.ToDecimal(row["fPrice"]);
            x.fCost = Convert.ToDecimal(row["fCost"]);
            x.fMemo = row["fMemo"].ToString();
            if (row["fImage"] != DBNull.Value)
                x.fImage = (byte[]) row["fImage"];
            FrmRoomEditor f = new FrmRoomEditor();
            f.room = x;
            f.ShowDialog();
            if (f.isOK == DialogResult.OK) 
            {
                row["fName"] = f.room.fName;
                row["fQty"] = f.room.fQty;
                row["fPrice"] = f.room.fPrice;
                row["fCost"] = f.room.fCost;
                row["fMemo"] = f.room.fMemo;
                row["fImage"] = f.room.fImage;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];
            row.Delete();
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tProduct WHERE ";
            sql += "fName LIKE @K_KEYWORD";
            sql += " OR fMemo LIKE @K_KEYWORD";
            displayRoomBySql(sql, true);      
        }

        private void resetGridStyle() 
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = dataGridView1.Width - 50 - 400 - 100 * 3 - dataGridView1.RowHeadersWidth;
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

        private void FrmRoomList_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i< dataGridView1.Rows.Count; i++)
            //{
            //    for(int j = 0; j< dataGridView1.Columns.Count; j++)
            //    {
            //        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtKeyword.Text))
            //        { 
            //            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
            //        }
            //    }
            //}
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        cell.Style.BackColor = Color.Empty;
            //    }
            //}
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0)
                        continue;
                    cell.Style.BackColor = row.Cells[0].Style.BackColor;
                    if (cell.Value.ToString().Contains(txtKeyword.Text) && !string.IsNullOrEmpty(txtKeyword.Text))
                        cell.Style.BackColor = Color.Yellow;
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (_ds == null)
                return;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            _ds.WriteXml(saveFileDialog1.FileName);
        }
    }
}
