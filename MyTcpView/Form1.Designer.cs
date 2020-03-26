namespace MyTcpView
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoteIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemotePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIcon,
            this.Column1,
            this.colPid,
            this.Column2,
            this.colLocalIP,
            this.colLocalPort,
            this.colRemoteIP,
            this.colRemotePort});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 579);
            this.dataGridView1.TabIndex = 1;
            // 
            // colIcon
            // 
            this.colIcon.HeaderText = "图标";
            this.colIcon.Name = "colIcon";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "进程名称";
            this.Column1.Name = "Column1";
            // 
            // colPid
            // 
            this.colPid.HeaderText = "进程号";
            this.colPid.Name = "colPid";
            this.colPid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "协议";
            this.Column2.Name = "Column2";
            // 
            // colLocalIP
            // 
            this.colLocalIP.HeaderText = "本地IP";
            this.colLocalIP.Name = "colLocalIP";
            this.colLocalIP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLocalIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLocalPort
            // 
            this.colLocalPort.HeaderText = "本地端口";
            this.colLocalPort.Name = "colLocalPort";
            this.colLocalPort.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLocalPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRemoteIP
            // 
            this.colRemoteIP.HeaderText = "远程IP";
            this.colRemoteIP.Name = "colRemoteIP";
            // 
            // colRemotePort
            // 
            this.colRemotePort.HeaderText = "远程端口";
            this.colRemotePort.Name = "colRemotePort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn colIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemoteIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemotePort;
    }
}

