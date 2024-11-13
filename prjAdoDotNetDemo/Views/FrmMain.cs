using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdoDotNetDemo.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.TopMost = true;
            f.ShowDialog();
        }

        private void 客戶管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCustomerSystem();
        }

        private void showCustomerSystem()
        {
            FrmCustomerList f = new FrmCustomerList();
            f.MdiParent = this;
            f.Show();
        }

        private void 房間資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRoomSystem();
        }

        private void showRoomSystem()
        {
            FrmRoomList f = new FrmRoomList();
            f.MdiParent = this;
            f.Show();
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 階梯式排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 關閉視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            showCustomerSystem();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmOrder f = new FrmOrder();
            f.MdiParent = this;
            f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f.Show();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmRoomList f = new FrmRoomList();
            f.MdiParent = this;
            f.Show();
        }
    }
}
