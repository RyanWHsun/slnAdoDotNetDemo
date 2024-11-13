using prjAdoDotNetDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdoDotNetDemo.Views
{
    public delegate void DRoomClick(CRoom p);
    public partial class RoomBox : UserControl
    {
        public event DRoomClick orderRoom;
        private CRoom _room;
        public RoomBox()
        {
            InitializeComponent();
        }

        public CRoom room
        { 
            get { return _room; }
            set
            {
                _room = value;
                lblMemo.Text = _room.fMemo;
                lblName.Text = _room.fName;
                lblPrice.Text = _room.fPrice.ToString();
                if (_room.fImage != null)
                {
                    Stream s = new MemoryStream(_room.fImage);
                    pictureBox1.Image = Bitmap.FromStream(s);
                }
            } 
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (orderRoom != null)
                orderRoom(this._room);
        }
        private void lblName_Click(object sender, EventArgs e)
        {
            if (orderRoom != null)
                orderRoom(this._room);
        }

        private void lblMemo_Click(object sender, EventArgs e)
        {
            if (orderRoom != null)
                orderRoom(this._room);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            if (orderRoom != null)
                orderRoom(this._room);
        }
    }
}
