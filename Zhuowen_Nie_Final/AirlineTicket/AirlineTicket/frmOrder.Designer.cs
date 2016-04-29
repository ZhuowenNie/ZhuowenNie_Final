namespace AirlineTicket
{
    partial class frmOrder
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
            this.gboxOrder = new System.Windows.Forms.GroupBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.dtpLeaveTime = new System.Windows.Forms.DateTimePicker();
            this.lblLeaveTime = new System.Windows.Forms.Label();
            this.txtFeightNo = new System.Windows.Forms.TextBox();
            this.lblFeightNo = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxOrder
            // 
            this.gboxOrder.Controls.Add(this.txtCardID);
            this.gboxOrder.Controls.Add(this.label2);
            this.gboxOrder.Controls.Add(this.txtCount);
            this.gboxOrder.Controls.Add(this.label1);
            this.gboxOrder.Controls.Add(this.lblType);
            this.gboxOrder.Controls.Add(this.cbxType);
            this.gboxOrder.Controls.Add(this.dtpLeaveTime);
            this.gboxOrder.Controls.Add(this.lblLeaveTime);
            this.gboxOrder.Controls.Add(this.txtFeightNo);
            this.gboxOrder.Controls.Add(this.lblFeightNo);
            this.gboxOrder.Location = new System.Drawing.Point(17, 16);
            this.gboxOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxOrder.Name = "gboxOrder";
            this.gboxOrder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxOrder.Size = new System.Drawing.Size(535, 219);
            this.gboxOrder.TabIndex = 0;
            this.gboxOrder.TabStop = false;
            this.gboxOrder.Text = "pre-book fly ticket";
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(100, 149);
            this.txtCardID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(409, 25);
            this.txtCardID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "IDCard：";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(100, 96);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(132, 25);
            this.txtCount.TabIndex = 17;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Num：";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(263, 38);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(86, 15);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "SeatType：";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "FirstClass",
            "Economy"});
            this.cbxType.Location = new System.Drawing.Point(357, 34);
            this.cbxType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(152, 23);
            this.cbxType.TabIndex = 14;
            // 
            // dtpLeaveTime
            // 
            this.dtpLeaveTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpLeaveTime.CustomFormat = "";
            this.dtpLeaveTime.Location = new System.Drawing.Point(357, 96);
            this.dtpLeaveTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpLeaveTime.Name = "dtpLeaveTime";
            this.dtpLeaveTime.Size = new System.Drawing.Size(152, 25);
            this.dtpLeaveTime.TabIndex = 13;
            this.dtpLeaveTime.Value = new System.DateTime(2016, 4, 20, 0, 0, 0, 0);
            this.dtpLeaveTime.ValueChanged += new System.EventHandler(this.dtpLeaveTime_ValueChanged);
            // 
            // lblLeaveTime
            // 
            this.lblLeaveTime.AutoSize = true;
            this.lblLeaveTime.Location = new System.Drawing.Point(235, 101);
            this.lblLeaveTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeaveTime.Name = "lblLeaveTime";
            this.lblLeaveTime.Size = new System.Drawing.Size(134, 15);
            this.lblLeaveTime.TabIndex = 12;
            this.lblLeaveTime.Text = "departure time：";
            // 
            // txtFeightNo
            // 
            this.txtFeightNo.Location = new System.Drawing.Point(100, 34);
            this.txtFeightNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFeightNo.Name = "txtFeightNo";
            this.txtFeightNo.Size = new System.Drawing.Size(132, 25);
            this.txtFeightNo.TabIndex = 11;
            // 
            // lblFeightNo
            // 
            this.lblFeightNo.AutoSize = true;
            this.lblFeightNo.Location = new System.Drawing.Point(17, 38);
            this.lblFeightNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeightNo.Name = "lblFeightNo";
            this.lblFeightNo.Size = new System.Drawing.Size(79, 15);
            this.lblFeightNo.TabIndex = 10;
            this.lblFeightNo.Text = "flightNo:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(151, 242);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 29);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Book";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 242);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 286);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gboxOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ticketBook";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.gboxOrder.ResumeLayout(false);
            this.gboxOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxOrder;
        private System.Windows.Forms.DateTimePicker dtpLeaveTime;
        private System.Windows.Forms.Label lblLeaveTime;
        private System.Windows.Forms.TextBox txtFeightNo;
        private System.Windows.Forms.Label lblFeightNo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardID;
    }
}