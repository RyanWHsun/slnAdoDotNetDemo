using prjAdoDotNetDemo.Models;
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
    public partial class FrmCustomerEditor : Form
    {
        public DialogResult isOK { get; set; }
        private CCustomer _customer;
        public FrmCustomerEditor()
        {
            InitializeComponent();
        }
        public CCustomer customer
        {
            get 
            {
                if (_customer == null)
                    { _customer = new CCustomer();}
                _customer.fId = Convert.ToInt32(fbId.filedValue);
                _customer.fName = fbName.filedValue;
                _customer.fPhone = fbPhone.filedValue;
                _customer.fEmail = fbEmail.filedValue;
                _customer.fAddress = fbAddress.filedValue;
                _customer.fPassword = fbPassword.filedValue;
                return _customer;
            }
            set 
            {
                _customer = value;
                fbId.filedValue = _customer.fId.ToString();
                fbName.filedValue = _customer.fName;
                fbPhone.filedValue = _customer.fPhone;
                fbEmail.filedValue = _customer.fEmail;
                fbAddress.filedValue = _customer.fAddress;
                fbPassword.filedValue = _customer.fPassword;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.isOK = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
