namespace AirlineTicket
{
    partial class frmUserMain
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
            this.gbxQuery = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtArriveCity = new System.Windows.Forms.TextBox();
            this.lblArriveCity = new System.Windows.Forms.Label();
            this.txtLeaveCity = new System.Windows.Forms.TextBox();
            this.lblLeaveCity = new System.Windows.Forms.Label();
            this.gbxOperation = new System.Windows.Forms.GroupBox();
            this.btnShowQuery = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gbxAriLine = new System.Windows.Forms.GroupBox();
            this.chkFirstClass = new System.Windows.Forms.CheckBox();
            this.chkSecondClass = new System.Windows.Forms.CheckBox();
            this.chkArriveCity = new System.Windows.Forms.CheckBox();
            this.chkLeaveCity = new System.Windows.Forms.CheckBox();
            this.chkFeightNo = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BookTicket = new System.Windows.Forms.TabPage();
            this.MyTicket = new System.Windows.Forms.TabPage();
            this.dataGridTicket = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbxQuery.SuspendLayout();
            this.gbxOperation.SuspendLayout();
            this.gbxAriLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.BookTicket.SuspendLayout();
            this.MyTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicket)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQuery
            // 
            this.gbxQuery.Controls.Add(this.btnQuery);
            this.gbxQuery.Controls.Add(this.txtArriveCity);
            this.gbxQuery.Controls.Add(this.lblArriveCity);
            this.gbxQuery.Controls.Add(this.txtLeaveCity);
            this.gbxQuery.Controls.Add(this.lblLeaveCity);
            this.gbxQuery.Location = new System.Drawing.Point(19, 330);
            this.gbxQuery.Name = "gbxQuery";
            this.gbxQuery.Size = new System.Drawing.Size(919, 55);
            this.gbxQuery.TabIndex = 1;
            this.gbxQuery.TabStop = false;
            this.gbxQuery.Text = "Inquire";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(809, 18);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "OK";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtArriveCity
            // 
            this.txtArriveCity.Location = new System.Drawing.Point(535, 23);
            this.txtArriveCity.Name = "txtArriveCity";
            this.txtArriveCity.Size = new System.Drawing.Size(100, 21);
            this.txtArriveCity.TabIndex = 3;
            // 
            // lblArriveCity
            // 
            this.lblArriveCity.AutoSize = true;
            this.lblArriveCity.Location = new System.Drawing.Point(466, 26);
            this.lblArriveCity.Name = "lblArriveCity";
            this.lblArriveCity.Size = new System.Drawing.Size(83, 12);
            this.lblArriveCity.TabIndex = 2;
            this.lblArriveCity.Text = "destination：";
            // 
            // txtLeaveCity
            // 
            this.txtLeaveCity.Location = new System.Drawing.Point(89, 18);
            this.txtLeaveCity.Name = "txtLeaveCity";
            this.txtLeaveCity.Size = new System.Drawing.Size(100, 21);
            this.txtLeaveCity.TabIndex = 1;
            // 
            // lblLeaveCity
            // 
            this.lblLeaveCity.AutoSize = true;
            this.lblLeaveCity.Location = new System.Drawing.Point(13, 26);
            this.lblLeaveCity.Name = "lblLeaveCity";
            this.lblLeaveCity.Size = new System.Drawing.Size(71, 12);
            this.lblLeaveCity.TabIndex = 0;
            this.lblLeaveCity.Text = "Departure：";
            // 
            // gbxOperation
            // 
            this.gbxOperation.Controls.Add(this.btnShowQuery);
            this.gbxOperation.Controls.Add(this.btnOrder);
            this.gbxOperation.Location = new System.Drawing.Point(838, 22);
            this.gbxOperation.Name = "gbxOperation";
            this.gbxOperation.Size = new System.Drawing.Size(144, 204);
            this.gbxOperation.TabIndex = 2;
            this.gbxOperation.TabStop = false;
            this.gbxOperation.Text = "Operating";
            // 
            // btnShowQuery
            // 
            this.btnShowQuery.Location = new System.Drawing.Point(34, 111);
            this.btnShowQuery.Name = "btnShowQuery";
            this.btnShowQuery.Size = new System.Drawing.Size(75, 23);
            this.btnShowQuery.TabIndex = 5;
            this.btnShowQuery.Text = "Inquire";
            this.btnShowQuery.UseVisualStyleBackColor = true;
            this.btnShowQuery.Click += new System.EventHandler(this.btnShowQuery_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(34, 56);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Book";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gbxAriLine
            // 
            this.gbxAriLine.Controls.Add(this.chkFirstClass);
            this.gbxAriLine.Controls.Add(this.chkSecondClass);
            this.gbxAriLine.Controls.Add(this.chkArriveCity);
            this.gbxAriLine.Controls.Add(this.chkLeaveCity);
            this.gbxAriLine.Controls.Add(this.chkFeightNo);
            this.gbxAriLine.Controls.Add(this.btnShow);
            this.gbxAriLine.Controls.Add(this.dgridView);
            this.gbxAriLine.Location = new System.Drawing.Point(34, 22);
            this.gbxAriLine.Name = "gbxAriLine";
            this.gbxAriLine.Size = new System.Drawing.Size(752, 295);
            this.gbxAriLine.TabIndex = 0;
            this.gbxAriLine.TabStop = false;
            this.gbxAriLine.Text = "flight information";
            // 
            // chkFirstClass
            // 
            this.chkFirstClass.AutoSize = true;
            this.chkFirstClass.Checked = true;
            this.chkFirstClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFirstClass.Location = new System.Drawing.Point(455, 21);
            this.chkFirstClass.Name = "chkFirstClass";
            this.chkFirstClass.Size = new System.Drawing.Size(72, 16);
            this.chkFirstClass.TabIndex = 6;
            this.chkFirstClass.Text = "Business";
            this.chkFirstClass.UseVisualStyleBackColor = true;
            // 
            // chkSecondClass
            // 
            this.chkSecondClass.AutoSize = true;
            this.chkSecondClass.Checked = true;
            this.chkSecondClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSecondClass.Location = new System.Drawing.Point(370, 22);
            this.chkSecondClass.Name = "chkSecondClass";
            this.chkSecondClass.Size = new System.Drawing.Size(66, 16);
            this.chkSecondClass.TabIndex = 5;
            this.chkSecondClass.Text = "Economy";
            this.chkSecondClass.UseVisualStyleBackColor = true;
            // 
            // chkArriveCity
            // 
            this.chkArriveCity.AutoSize = true;
            this.chkArriveCity.Checked = true;
            this.chkArriveCity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkArriveCity.Location = new System.Drawing.Point(285, 22);
            this.chkArriveCity.Name = "chkArriveCity";
            this.chkArriveCity.Size = new System.Drawing.Size(90, 16);
            this.chkArriveCity.TabIndex = 4;
            this.chkArriveCity.Text = "destination";
            this.chkArriveCity.UseVisualStyleBackColor = true;
            // 
            // chkLeaveCity
            // 
            this.chkLeaveCity.AutoSize = true;
            this.chkLeaveCity.Checked = true;
            this.chkLeaveCity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLeaveCity.Location = new System.Drawing.Point(200, 23);
            this.chkLeaveCity.Name = "chkLeaveCity";
            this.chkLeaveCity.Size = new System.Drawing.Size(78, 16);
            this.chkLeaveCity.TabIndex = 3;
            this.chkLeaveCity.Text = "Departure";
            this.chkLeaveCity.UseVisualStyleBackColor = true;
            // 
            // chkFeightNo
            // 
            this.chkFeightNo.AutoSize = true;
            this.chkFeightNo.Checked = true;
            this.chkFeightNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFeightNo.Location = new System.Drawing.Point(115, 24);
            this.chkFeightNo.Name = "chkFeightNo";
            this.chkFeightNo.Size = new System.Drawing.Size(72, 16);
            this.chkFeightNo.TabIndex = 2;
            this.chkFeightNo.Text = "FlightNo";
            this.chkFeightNo.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(6, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Title";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgridView
            // 
            this.dgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridView.Location = new System.Drawing.Point(6, 43);
            this.dgridView.Name = "dgridView";
            this.dgridView.RowTemplate.Height = 23;
            this.dgridView.Size = new System.Drawing.Size(740, 246);
            this.dgridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BookTicket);
            this.tabControl1.Controls.Add(this.MyTicket);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 509);
            this.tabControl1.TabIndex = 3;
            // 
            // BookTicket
            // 
            this.BookTicket.Controls.Add(this.gbxAriLine);
            this.BookTicket.Controls.Add(this.gbxOperation);
            this.BookTicket.Controls.Add(this.gbxQuery);
            this.BookTicket.Location = new System.Drawing.Point(4, 22);
            this.BookTicket.Name = "BookTicket";
            this.BookTicket.Padding = new System.Windows.Forms.Padding(3);
            this.BookTicket.Size = new System.Drawing.Size(1033, 483);
            this.BookTicket.TabIndex = 0;
            this.BookTicket.Text = "BookTicket";
            this.BookTicket.UseVisualStyleBackColor = true;
            // 
            // MyTicket
            // 
            this.MyTicket.Controls.Add(this.groupBox1);
            this.MyTicket.Controls.Add(this.dataGridTicket);
            this.MyTicket.Location = new System.Drawing.Point(4, 22);
            this.MyTicket.Name = "MyTicket";
            this.MyTicket.Padding = new System.Windows.Forms.Padding(3);
            this.MyTicket.Size = new System.Drawing.Size(1033, 483);
            this.MyTicket.TabIndex = 1;
            this.MyTicket.Text = "MyTicket";
            this.MyTicket.UseVisualStyleBackColor = true;
            // 
            // dataGridTicket
            // 
            this.dataGridTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTicket.Location = new System.Drawing.Point(55, 43);
            this.dataGridTicket.Name = "dataGridTicket";
            this.dataGridTicket.RowTemplate.Height = 23;
            this.dataGridTicket.Size = new System.Drawing.Size(588, 348);
            this.dataGridTicket.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(824, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operating";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "unbook";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 509);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmUserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxQuery.ResumeLayout(false);
            this.gbxQuery.PerformLayout();
            this.gbxOperation.ResumeLayout(false);
            this.gbxAriLine.ResumeLayout(false);
            this.gbxAriLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.BookTicket.ResumeLayout(false);
            this.MyTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicket)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtArriveCity;
        private System.Windows.Forms.Label lblArriveCity;
        private System.Windows.Forms.TextBox txtLeaveCity;
        private System.Windows.Forms.Label lblLeaveCity;
        private System.Windows.Forms.GroupBox gbxOperation;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnShowQuery;
        private System.Windows.Forms.GroupBox gbxAriLine;
        private System.Windows.Forms.CheckBox chkFirstClass;
        private System.Windows.Forms.CheckBox chkSecondClass;
        private System.Windows.Forms.CheckBox chkArriveCity;
        private System.Windows.Forms.CheckBox chkLeaveCity;
        private System.Windows.Forms.CheckBox chkFeightNo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BookTicket;
        private System.Windows.Forms.TabPage MyTicket;
        private System.Windows.Forms.DataGridView dataGridTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}

