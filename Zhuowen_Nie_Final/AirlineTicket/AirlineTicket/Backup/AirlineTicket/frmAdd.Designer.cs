namespace AirlineTicket
{
    partial class frmAdd
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxAirline = new System.Windows.Forms.GroupBox();
            this.txtSeatCount = new System.Windows.Forms.TextBox();
            this.lblSeatCount = new System.Windows.Forms.Label();
            this.txtFirstPrice = new System.Windows.Forms.TextBox();
            this.txtSecondPrice = new System.Windows.Forms.TextBox();
            this.dtpArriveTime = new System.Windows.Forms.DateTimePicker();
            this.lblArriveTime = new System.Windows.Forms.Label();
            this.dtpLeaveTime = new System.Windows.Forms.DateTimePicker();
            this.txtArriveCity = new System.Windows.Forms.TextBox();
            this.txtLeaveCity = new System.Windows.Forms.TextBox();
            this.lblFirstClass = new System.Windows.Forms.Label();
            this.lblSecondClass = new System.Windows.Forms.Label();
            this.lblLeaveTime = new System.Windows.Forms.Label();
            this.lblArriveCity = new System.Windows.Forms.Label();
            this.lblLeaveCity = new System.Windows.Forms.Label();
            this.txtFeightNo = new System.Windows.Forms.TextBox();
            this.lblFeightNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxAirline.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAirline
            // 
            this.gbxAirline.Controls.Add(this.txtSeatCount);
            this.gbxAirline.Controls.Add(this.lblSeatCount);
            this.gbxAirline.Controls.Add(this.txtFirstPrice);
            this.gbxAirline.Controls.Add(this.txtSecondPrice);
            this.gbxAirline.Controls.Add(this.dtpArriveTime);
            this.gbxAirline.Controls.Add(this.lblArriveTime);
            this.gbxAirline.Controls.Add(this.dtpLeaveTime);
            this.gbxAirline.Controls.Add(this.txtArriveCity);
            this.gbxAirline.Controls.Add(this.txtLeaveCity);
            this.gbxAirline.Controls.Add(this.lblFirstClass);
            this.gbxAirline.Controls.Add(this.lblSecondClass);
            this.gbxAirline.Controls.Add(this.lblLeaveTime);
            this.gbxAirline.Controls.Add(this.lblArriveCity);
            this.gbxAirline.Controls.Add(this.lblLeaveCity);
            this.gbxAirline.Controls.Add(this.txtFeightNo);
            this.gbxAirline.Controls.Add(this.lblFeightNo);
            this.gbxAirline.Location = new System.Drawing.Point(13, 13);
            this.gbxAirline.Name = "gbxAirline";
            this.gbxAirline.Size = new System.Drawing.Size(403, 170);
            this.gbxAirline.TabIndex = 0;
            this.gbxAirline.TabStop = false;
            this.gbxAirline.Text = "航班信息";
            // 
            // txtSeatCount
            // 
            this.txtSeatCount.Location = new System.Drawing.Point(283, 20);
            this.txtSeatCount.Name = "txtSeatCount";
            this.txtSeatCount.Size = new System.Drawing.Size(100, 21);
            this.txtSeatCount.TabIndex = 15;
            this.txtSeatCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeatCount_KeyPress);
            // 
            // lblSeatCount
            // 
            this.lblSeatCount.AutoSize = true;
            this.lblSeatCount.Location = new System.Drawing.Point(217, 24);
            this.lblSeatCount.Name = "lblSeatCount";
            this.lblSeatCount.Size = new System.Drawing.Size(53, 12);
            this.lblSeatCount.TabIndex = 14;
            this.lblSeatCount.Text = "座位数：";
            // 
            // txtFirstPrice
            // 
            this.txtFirstPrice.Location = new System.Drawing.Point(283, 130);
            this.txtFirstPrice.Name = "txtFirstPrice";
            this.txtFirstPrice.Size = new System.Drawing.Size(100, 21);
            this.txtFirstPrice.TabIndex = 13;
            this.txtFirstPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstPrice_KeyPress);
            // 
            // txtSecondPrice
            // 
            this.txtSecondPrice.Location = new System.Drawing.Point(97, 129);
            this.txtSecondPrice.Name = "txtSecondPrice";
            this.txtSecondPrice.Size = new System.Drawing.Size(100, 21);
            this.txtSecondPrice.TabIndex = 12;
            this.txtSecondPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondPrice_KeyPress);
            // 
            // dtpArriveTime
            // 
            this.dtpArriveTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpArriveTime.CustomFormat = "{0:d}";
            this.dtpArriveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpArriveTime.Location = new System.Drawing.Point(283, 93);
            this.dtpArriveTime.Name = "dtpArriveTime";
            this.dtpArriveTime.Size = new System.Drawing.Size(100, 21);
            this.dtpArriveTime.TabIndex = 11;
            this.dtpArriveTime.Value = new System.DateTime(2009, 6, 23, 0, 0, 0, 0);
            // 
            // lblArriveTime
            // 
            this.lblArriveTime.AutoSize = true;
            this.lblArriveTime.Location = new System.Drawing.Point(215, 96);
            this.lblArriveTime.Name = "lblArriveTime";
            this.lblArriveTime.Size = new System.Drawing.Size(65, 12);
            this.lblArriveTime.TabIndex = 10;
            this.lblArriveTime.Text = "到达时间：";
            // 
            // dtpLeaveTime
            // 
            this.dtpLeaveTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpLeaveTime.CustomFormat = "";
            this.dtpLeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpLeaveTime.Location = new System.Drawing.Point(97, 93);
            this.dtpLeaveTime.Name = "dtpLeaveTime";
            this.dtpLeaveTime.Size = new System.Drawing.Size(100, 21);
            this.dtpLeaveTime.TabIndex = 9;
            this.dtpLeaveTime.Value = new System.DateTime(2009, 12, 23, 0, 0, 0, 0);
            // 
            // txtArriveCity
            // 
            this.txtArriveCity.Location = new System.Drawing.Point(283, 56);
            this.txtArriveCity.Name = "txtArriveCity";
            this.txtArriveCity.Size = new System.Drawing.Size(100, 21);
            this.txtArriveCity.TabIndex = 8;
            // 
            // txtLeaveCity
            // 
            this.txtLeaveCity.Location = new System.Drawing.Point(97, 57);
            this.txtLeaveCity.Name = "txtLeaveCity";
            this.txtLeaveCity.Size = new System.Drawing.Size(100, 21);
            this.txtLeaveCity.TabIndex = 7;
            // 
            // lblFirstClass
            // 
            this.lblFirstClass.AutoSize = true;
            this.lblFirstClass.Location = new System.Drawing.Point(215, 131);
            this.lblFirstClass.Name = "lblFirstClass";
            this.lblFirstClass.Size = new System.Drawing.Size(65, 12);
            this.lblFirstClass.TabIndex = 6;
            this.lblFirstClass.Text = "头等仓位：";
            // 
            // lblSecondClass
            // 
            this.lblSecondClass.AutoSize = true;
            this.lblSecondClass.Location = new System.Drawing.Point(21, 131);
            this.lblSecondClass.Name = "lblSecondClass";
            this.lblSecondClass.Size = new System.Drawing.Size(65, 12);
            this.lblSecondClass.TabIndex = 5;
            this.lblSecondClass.Text = "经济仓位：";
            // 
            // lblLeaveTime
            // 
            this.lblLeaveTime.AutoSize = true;
            this.lblLeaveTime.Location = new System.Drawing.Point(21, 96);
            this.lblLeaveTime.Name = "lblLeaveTime";
            this.lblLeaveTime.Size = new System.Drawing.Size(65, 12);
            this.lblLeaveTime.TabIndex = 4;
            this.lblLeaveTime.Text = "出发时间：";
            // 
            // lblArriveCity
            // 
            this.lblArriveCity.AutoSize = true;
            this.lblArriveCity.Location = new System.Drawing.Point(215, 59);
            this.lblArriveCity.Name = "lblArriveCity";
            this.lblArriveCity.Size = new System.Drawing.Size(53, 12);
            this.lblArriveCity.TabIndex = 3;
            this.lblArriveCity.Text = "目的地：";
            // 
            // lblLeaveCity
            // 
            this.lblLeaveCity.AutoSize = true;
            this.lblLeaveCity.Location = new System.Drawing.Point(21, 59);
            this.lblLeaveCity.Name = "lblLeaveCity";
            this.lblLeaveCity.Size = new System.Drawing.Size(53, 12);
            this.lblLeaveCity.TabIndex = 2;
            this.lblLeaveCity.Text = "出发地：";
            // 
            // txtFeightNo
            // 
            this.txtFeightNo.Location = new System.Drawing.Point(97, 21);
            this.txtFeightNo.Name = "txtFeightNo";
            this.txtFeightNo.Size = new System.Drawing.Size(100, 21);
            this.txtFeightNo.TabIndex = 1;
            // 
            // lblFeightNo
            // 
            this.lblFeightNo.AutoSize = true;
            this.lblFeightNo.Location = new System.Drawing.Point(21, 24);
            this.lblFeightNo.Name = "lblFeightNo";
            this.lblFeightNo.Size = new System.Drawing.Size(53, 12);
            this.lblFeightNo.TabIndex = 0;
            this.lblFeightNo.Text = "航班号：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添  加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 231);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxAirline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加航班信息";
            this.gbxAirline.ResumeLayout(false);
            this.gbxAirline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAirline;
        private System.Windows.Forms.TextBox txtFeightNo;
        private System.Windows.Forms.Label lblFeightNo;
        private System.Windows.Forms.Label lblLeaveTime;
        private System.Windows.Forms.Label lblArriveCity;
        private System.Windows.Forms.Label lblLeaveCity;
        private System.Windows.Forms.Label lblFirstClass;
        private System.Windows.Forms.Label lblSecondClass;
        private System.Windows.Forms.TextBox txtArriveCity;
        private System.Windows.Forms.TextBox txtLeaveCity;
        private System.Windows.Forms.DateTimePicker dtpLeaveTime;
        private System.Windows.Forms.Label lblArriveTime;
        private System.Windows.Forms.DateTimePicker dtpArriveTime;
        private System.Windows.Forms.TextBox txtFirstPrice;
        private System.Windows.Forms.TextBox txtSecondPrice;
        private System.Windows.Forms.Label lblSeatCount;
        private System.Windows.Forms.TextBox txtSeatCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}