namespace InformationService.Client
{
    partial class ClientForm
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
            this.sendMessageBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.online = new System.Windows.Forms.Button();
            this.offline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(12, 36);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(273, 186);
            this.displayBox.TabIndex = 0;
            // 
            // sendMessageBox
            // 
            this.sendMessageBox.Location = new System.Drawing.Point(12, 228);
            this.sendMessageBox.Name = "sendMessageBox";
            this.sendMessageBox.Size = new System.Drawing.Size(213, 21);
            this.sendMessageBox.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(247, 228);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // online
            // 
            this.online.Location = new System.Drawing.Point(12, 5);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(63, 25);
            this.online.TabIndex = 3;
            this.online.Text = "上线";
            this.online.UseVisualStyleBackColor = true;
            this.online.Click += new System.EventHandler(this.online_Click);
            // 
            // offline
            // 
            this.offline.Location = new System.Drawing.Point(95, 5);
            this.offline.Name = "offline";
            this.offline.Size = new System.Drawing.Size(63, 25);
            this.offline.TabIndex = 4;
            this.offline.Text = "下线";
            this.offline.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.offline);
            this.Controls.Add(this.online);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendMessageBox);
            this.Controls.Add(this.displayBox);
            this.Name = "ClientForm";
            this.Text = "客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.TextBox sendMessageBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button online;
        private System.Windows.Forms.Button offline;
    }
}

