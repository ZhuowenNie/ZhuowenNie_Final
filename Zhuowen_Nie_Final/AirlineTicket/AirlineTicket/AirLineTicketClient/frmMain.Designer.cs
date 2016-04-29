namespace AirLineTicketClient
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrdView = new System.Windows.Forms.DataGridView();
            this.gbxOperator = new System.Windows.Forms.GroupBox();
            this.btnOffborad = new System.Windows.Forms.Button();
            this.btnOnBorad = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gboxQuery = new System.Windows.Forms.GroupBox();
            this.txtFeightNo = new System.Windows.Forms.TextBox();
            this.lblFeifhtNO = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.lblCardID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdView)).BeginInit();
            this.gbxOperator.SuspendLayout();
            this.gboxQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrdView);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flights information";
            // 
            // dgrdView
            // 
            this.dgrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdView.Location = new System.Drawing.Point(7, 20);
            this.dgrdView.Name = "dgrdView";
            this.dgrdView.RowTemplate.Height = 23;
            this.dgrdView.Size = new System.Drawing.Size(642, 243);
            this.dgrdView.TabIndex = 0;
            // 
            // gbxOperator
            // 
            this.gbxOperator.Controls.Add(this.btnOffborad);
            this.gbxOperator.Controls.Add(this.btnOnBorad);
            this.gbxOperator.Controls.Add(this.btnLogin);
            this.gbxOperator.Controls.Add(this.btnDelete);
            this.gbxOperator.Location = new System.Drawing.Point(682, 91);
            this.gbxOperator.Name = "gbxOperator";
            this.gbxOperator.Size = new System.Drawing.Size(124, 270);
            this.gbxOperator.TabIndex = 1;
            this.gbxOperator.TabStop = false;
            this.gbxOperator.Text = "Operation";
            // 
            // btnOffborad
            // 
            this.btnOffborad.Location = new System.Drawing.Point(23, 166);
            this.btnOffborad.Name = "btnOffborad";
            this.btnOffborad.Size = new System.Drawing.Size(75, 23);
            this.btnOffborad.TabIndex = 3;
            this.btnOffborad.Text = "No boarding";
            this.btnOffborad.UseVisualStyleBackColor = true;
            this.btnOffborad.Click += new System.EventHandler(this.btnOffborad_Click);
            // 
            // btnOnBorad
            // 
            this.btnOnBorad.Location = new System.Drawing.Point(23, 93);
            this.btnOnBorad.Name = "btnOnBorad";
            this.btnOnBorad.Size = new System.Drawing.Size(75, 23);
            this.btnOnBorad.TabIndex = 2;
            this.btnOnBorad.Text = "been boarding";
            this.btnOnBorad.UseVisualStyleBackColor = true;
            this.btnOnBorad.Click += new System.EventHandler(this.btnOnBorad_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(23, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Boarding";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(23, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Return ticket";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gboxQuery
            // 
            this.gboxQuery.Controls.Add(this.txtFeightNo);
            this.gboxQuery.Controls.Add(this.lblFeifhtNO);
            this.gboxQuery.Controls.Add(this.btnQuery);
            this.gboxQuery.Controls.Add(this.txtCardID);
            this.gboxQuery.Controls.Add(this.lblCardID);
            this.gboxQuery.Location = new System.Drawing.Point(12, 10);
            this.gboxQuery.Name = "gboxQuery";
            this.gboxQuery.Size = new System.Drawing.Size(793, 55);
            this.gboxQuery.TabIndex = 2;
            this.gboxQuery.TabStop = false;
            this.gboxQuery.Text = "Discover airfares";
            this.gboxQuery.Enter += new System.EventHandler(this.gboxQuery_Enter);
            // 
            // txtFeightNo
            // 
            this.txtFeightNo.Location = new System.Drawing.Point(66, 18);
            this.txtFeightNo.Name = "txtFeightNo";
            this.txtFeightNo.Size = new System.Drawing.Size(100, 21);
            this.txtFeightNo.TabIndex = 4;
            // 
            // lblFeifhtNO
            // 
            this.lblFeifhtNO.AutoSize = true;
            this.lblFeifhtNO.Location = new System.Drawing.Point(6, 22);
            this.lblFeifhtNO.Name = "lblFeifhtNO";
            this.lblFeifhtNO.Size = new System.Drawing.Size(65, 12);
            this.lblFeifhtNO.TabIndex = 3;
            this.lblFeifhtNO.Text = "FlightNo：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(692, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Inquire";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(271, 19);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(376, 21);
            this.txtCardID.TabIndex = 1;
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(200, 22);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(53, 12);
            this.lblCardID.TabIndex = 0;
            this.lblCardID.Text = "IDCard：";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 366);
            this.Controls.Add(this.gboxQuery);
            this.Controls.Add(this.gbxOperator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boarding ticket system";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdView)).EndInit();
            this.gbxOperator.ResumeLayout(false);
            this.gboxQuery.ResumeLayout(false);
            this.gboxQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxOperator;
        private System.Windows.Forms.GroupBox gboxQuery;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgrdView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFeifhtNO;
        private System.Windows.Forms.TextBox txtFeightNo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOffborad;
        private System.Windows.Forms.Button btnOnBorad;
    }
}

