using prjAdoDotNetDemo.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace prjAdoDotNetDemo.Views
{
    public partial class FrmRoomEditor : Form
    {
        private CRoom _room;
        public FrmRoomEditor()
        {
            InitializeComponent();
        }
        public CRoom room
        {
            get 
            {
                if (_room == null)
                    _room = new CRoom();
                _room.fId = Convert.ToInt32(fbId.filedValue);
                _room.fName = fbName.filedValue;
                _room.fQty = Convert.ToInt32(fbQty.filedValue);
                _room.fPrice = Convert.ToDecimal(fbPrice.filedValue);
                _room.fCost = Convert.ToDecimal(fbCost.filedValue);
                _room.fMemo = fbMemo.filedValue;
                return _room;
            } 
            set
            {
                _room = value;
                fbId.filedValue = _room.fId.ToString();
                fbName.filedValue = _room.fName;
                fbQty.filedValue = _room.fQty.ToString();
                fbPrice.filedValue = _room.fPrice.ToString();
                fbCost.filedValue = _room.fCost.ToString();
                fbMemo.filedValue = _room.fMemo;
                if (_room.fImage != null)
                {
                    Stream streamImage = new MemoryStream(_room.fImage);
                    pictureBox1.Image = Bitmap.FromStream(streamImage);
                }
            } 
        }

        public DialogResult isOK { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(fbName.filedValue))
                message += "\r\n房型為*必填";
            if (string.IsNullOrEmpty(fbPrice.filedValue))
                message += "\r\n價格為*必填";
            else 
            {
                if (!isNumber(fbPrice.filedValue))
                {
                    message += "\r\n價格必須為數字";
                }
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }
            this.isOK = DialogResult.OK;
            Close();
        }

        private bool isNumber(string p)
        {
            try
            {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "房間照片|*.png|房間照片|*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            this.room.fImage = reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }
    }
}
