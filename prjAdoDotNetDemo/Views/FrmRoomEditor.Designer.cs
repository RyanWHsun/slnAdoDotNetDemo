namespace prjAdoDotNetDemo.Views
{
    partial class FrmRoomEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fbCost = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbMemo = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbPrice = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbQty = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbName = new prjAdoDotNetDemo.Views.FieldBox();
            this.fbId = new prjAdoDotNetDemo.Views.FieldBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(32, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 2);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(514, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "確定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(423, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "*必填";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(388, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "點擊兩下選取圖片";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fbCost
            // 
            this.fbCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbCost.filedName = "成本";
            this.fbCost.filedValue = "10000";
            this.fbCost.Location = new System.Drawing.Point(37, 168);
            this.fbCost.Name = "fbCost";
            this.fbCost.passwordMask = '\0';
            this.fbCost.Size = new System.Drawing.Size(132, 46);
            this.fbCost.TabIndex = 16;
            // 
            // fbMemo
            // 
            this.fbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbMemo.filedName = "說明";
            this.fbMemo.filedValue = "";
            this.fbMemo.Location = new System.Drawing.Point(37, 220);
            this.fbMemo.Name = "fbMemo";
            this.fbMemo.passwordMask = '\0';
            this.fbMemo.Size = new System.Drawing.Size(318, 46);
            this.fbMemo.TabIndex = 4;
            // 
            // fbPrice
            // 
            this.fbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbPrice.filedName = "價格";
            this.fbPrice.filedValue = "100000";
            this.fbPrice.Location = new System.Drawing.Point(218, 168);
            this.fbPrice.Name = "fbPrice";
            this.fbPrice.passwordMask = '\0';
            this.fbPrice.Size = new System.Drawing.Size(137, 46);
            this.fbPrice.TabIndex = 3;
            // 
            // fbQty
            // 
            this.fbQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbQty.filedName = "數量";
            this.fbQty.filedValue = "1";
            this.fbQty.Location = new System.Drawing.Point(37, 116);
            this.fbQty.Name = "fbQty";
            this.fbQty.passwordMask = '\0';
            this.fbQty.Size = new System.Drawing.Size(318, 46);
            this.fbQty.TabIndex = 2;
            // 
            // fbName
            // 
            this.fbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbName.filedName = "房型";
            this.fbName.filedValue = "";
            this.fbName.Location = new System.Drawing.Point(37, 64);
            this.fbName.Name = "fbName";
            this.fbName.passwordMask = '\0';
            this.fbName.Size = new System.Drawing.Size(318, 46);
            this.fbName.TabIndex = 1;
            // 
            // fbId
            // 
            this.fbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbId.filedName = "編號";
            this.fbId.filedValue = "0";
            this.fbId.Location = new System.Drawing.Point(37, 12);
            this.fbId.Name = "fbId";
            this.fbId.passwordMask = '\0';
            this.fbId.Size = new System.Drawing.Size(318, 46);
            this.fbId.TabIndex = 0;
            this.fbId.Visible = false;
            // 
            // FrmRoomEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fbCost);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbMemo);
            this.Controls.Add(this.fbPrice);
            this.Controls.Add(this.fbQty);
            this.Controls.Add(this.fbName);
            this.Controls.Add(this.fbId);
            this.Name = "FrmRoomEditor";
            this.Text = "FrmRoomEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FieldBox fbId;
        private FieldBox fbName;
        private FieldBox fbQty;
        private FieldBox fbPrice;
        private FieldBox fbMemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private FieldBox fbCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}