namespace InformationService.Server
{
    partial class SeverForm
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
            this.displayBox = new System.Windows.Forms.TextBox();
            this.openServer = new System.Windows.Forms.Button();
            this.stopServer = new System.Windows.Forms.Button();
            this.onlineCount = new System.Windows.Forms.Button();
            this.asyncPool = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectPool = new System.Windows.Forms.TextBox();
            this.handlePool = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(13, 13);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(275, 219);
            this.displayBox.TabIndex = 0;
            // 
            // openServer
            // 
            this.openServer.Location = new System.Drawing.Point(309, 40);
            this.openServer.Name = "openServer";
            this.openServer.Size = new System.Drawing.Size(63, 23);
            this.openServer.TabIndex = 1;
            this.openServer.Text = "开启";
            this.openServer.UseVisualStyleBackColor = true;
            this.openServer.Click += new System.EventHandler(this.openServer_Click);
            // 
            // stopServer
            // 
            this.stopServer.Location = new System.Drawing.Point(309, 99);
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(63, 23);
            this.stopServer.TabIndex = 2;
            this.stopServer.Text = "暂停";
            this.stopServer.UseVisualStyleBackColor = true;
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // onlineCount
            // 
            this.onlineCount.Location = new System.Drawing.Point(297, 162);
            this.onlineCount.Name = "onlineCount";
            this.onlineCount.Size = new System.Drawing.Size(75, 23);
            this.onlineCount.TabIndex = 3;
            this.onlineCount.Text = "在线人员";
            this.onlineCount.UseVisualStyleBackColor = true;
            // 
            // asyncPool
            // 
            this.asyncPool.Location = new System.Drawing.Point(297, 250);
            this.asyncPool.Name = "asyncPool";
            this.asyncPool.Size = new System.Drawing.Size(75, 23);
            this.asyncPool.TabIndex = 4;
            this.asyncPool.Text = "异步池监测";
            this.asyncPool.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "连接池：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "处理池：";
            // 
            // connectPool
            // 
            this.connectPool.Location = new System.Drawing.Point(90, 247);
            this.connectPool.Name = "connectPool";
            this.connectPool.Size = new System.Drawing.Size(100, 21);
            this.connectPool.TabIndex = 7;
            // 
            // handlePool
            // 
            this.handlePool.Location = new System.Drawing.Point(90, 277);
            this.handlePool.Name = "handlePool";
            this.handlePool.Size = new System.Drawing.Size(100, 21);
            this.handlePool.TabIndex = 8;
            // 
            // SeverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.handlePool);
            this.Controls.Add(this.connectPool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asyncPool);
            this.Controls.Add(this.onlineCount);
            this.Controls.Add(this.stopServer);
            this.Controls.Add(this.openServer);
            this.Controls.Add(this.displayBox);
            this.Name = "SeverForm";
            this.Text = "服务器端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button openServer;
        private System.Windows.Forms.Button stopServer;
        private System.Windows.Forms.Button onlineCount;
        private System.Windows.Forms.Button asyncPool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox connectPool;
        private System.Windows.Forms.TextBox handlePool;
    }
}

