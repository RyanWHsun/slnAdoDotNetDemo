namespace prjAdoDotNetDemo.Views
{
    partial class FrmLogin
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
            this.fieldBox2 = new prjAdoDotNetDemo.Views.FieldBox();
            this.fieldBox1 = new prjAdoDotNetDemo.Views.FieldBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fieldBox2
            // 
            this.fieldBox2.filedName = "密碼";
            this.fieldBox2.filedValue = "";
            this.fieldBox2.Location = new System.Drawing.Point(130, 116);
            this.fieldBox2.Name = "fieldBox2";
            this.fieldBox2.passwordMask = '\0';
            this.fieldBox2.Size = new System.Drawing.Size(324, 46);
            this.fieldBox2.TabIndex = 1;
            // 
            // fieldBox1
            // 
            this.fieldBox1.filedName = "帳號";
            this.fieldBox1.filedValue = "";
            this.fieldBox1.Location = new System.Drawing.Point(130, 64);
            this.fieldBox1.Name = "fieldBox1";
            this.fieldBox1.passwordMask = '\0';
            this.fieldBox1.Size = new System.Drawing.Size(324, 46);
            this.fieldBox1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fieldBox2);
            this.Controls.Add(this.fieldBox1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FieldBox fieldBox1;
        private FieldBox fieldBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}