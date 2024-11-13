namespace prjAdoDotNetDemo.Views
{
    partial class FrmCustomerEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fbPassword = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbAddress = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbEmail = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbPhone = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbId = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbName = new prjAdoDotNetDemo.Views.FieldBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(25, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(123, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "確定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(23, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 2);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // fbPassword
            // 
            this.fbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbPassword.filedName = "密碼";
            this.fbPassword.filedValue = "";
            this.fbPassword.Location = new System.Drawing.Point(25, 283);
            this.fbPassword.Name = "fbPassword";
            this.fbPassword.Size = new System.Drawing.Size(196, 46);
            this.fbPassword.TabIndex = 31;
            // 
            // fbAddress
            // 
            this.fbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbAddress.filedName = "地址";
            this.fbAddress.filedValue = "";
            this.fbAddress.Location = new System.Drawing.Point(25, 231);
            this.fbAddress.Name = "fbAddress";
            this.fbAddress.Size = new System.Drawing.Size(196, 46);
            this.fbAddress.TabIndex = 30;
            // 
            // fbEmail
            // 
            this.fbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbEmail.filedName = "電子郵件";
            this.fbEmail.filedValue = "";
            this.fbEmail.Location = new System.Drawing.Point(25, 179);
            this.fbEmail.Name = "fbEmail";
            this.fbEmail.Size = new System.Drawing.Size(196, 46);
            this.fbEmail.TabIndex = 29;
            // 
            // fbPhone
            // 
            this.fbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbPhone.filedName = "電話";
            this.fbPhone.filedValue = "";
            this.fbPhone.Location = new System.Drawing.Point(25, 127);
            this.fbPhone.Name = "fbPhone";
            this.fbPhone.Size = new System.Drawing.Size(196, 46);
            this.fbPhone.TabIndex = 28;
            // 
            // fbId
            // 
            this.fbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbId.filedName = "客戶編號";
            this.fbId.filedValue = "0";
            this.fbId.Location = new System.Drawing.Point(25, 23);
            this.fbId.Name = "fbId";
            this.fbId.Size = new System.Drawing.Size(196, 46);
            this.fbId.TabIndex = 27;
            this.fbId.Visible = false;
            // 
            // fbName
            // 
            this.fbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbName.filedName = "姓名";
            this.fbName.filedValue = "";
            this.fbName.Location = new System.Drawing.Point(25, 75);
            this.fbName.Name = "fbName";
            this.fbName.Size = new System.Drawing.Size(196, 46);
            this.fbName.TabIndex = 26;
            // 
            // FrmCustomerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbPassword);
            this.Controls.Add(this.fbAddress);
            this.Controls.Add(this.fbEmail);
            this.Controls.Add(this.fbPhone);
            this.Controls.Add(this.fbId);
            this.Controls.Add(this.fbName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmCustomerEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomerEditor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FieldBox fbName;
        private FieldBox fbId;
        private FieldBox fbPhone;
        private FieldBox fbEmail;
        private FieldBox fbAddress;
        private FieldBox fbPassword;
        private System.Windows.Forms.Label label1;
    }
}