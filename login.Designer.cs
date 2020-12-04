namespace Gateway
{
    partial class login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new HZH_Controls.Controls.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.PassWord = new HZH_Controls.Controls.TextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.DecLength = 2;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.InputType = HZH_Controls.TextInputType.NotControl;
            this.UserName.Location = new System.Drawing.Point(230, 131);
            this.UserName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.UserName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.UserName.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.UserName.Name = "UserName";
            this.UserName.OldText = null;
            this.UserName.PromptColor = System.Drawing.Color.Gray;
            this.UserName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserName.PromptText = "";
            this.UserName.RegexPattern = "";
            this.UserName.Size = new System.Drawing.Size(119, 31);
            this.UserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(109, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // PassWord
            // 
            this.PassWord.DecLength = 2;
            this.PassWord.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassWord.InputType = HZH_Controls.TextInputType.NotControl;
            this.PassWord.Location = new System.Drawing.Point(230, 194);
            this.PassWord.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PassWord.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.PassWord.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PassWord.Name = "PassWord";
            this.PassWord.OldText = null;
            this.PassWord.PromptColor = System.Drawing.Color.Gray;
            this.PassWord.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PassWord.PromptText = "";
            this.PassWord.RegexPattern = "";
            this.PassWord.Size = new System.Drawing.Size(119, 31);
            this.PassWord.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(121, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Silver;
            this.loginBtn.BtnBackColor = System.Drawing.Color.Silver;
            this.loginBtn.BtnFont = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginBtn.BtnForeColor = System.Drawing.Color.Black;
            this.loginBtn.BtnText = "登录";
            this.loginBtn.ConerRadius = 50;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.EnabledMouseEffect = false;
            this.loginBtn.FillColor = System.Drawing.Color.Silver;
            this.loginBtn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginBtn.IsRadius = true;
            this.loginBtn.IsShowRect = true;
            this.loginBtn.IsShowTips = false;
            this.loginBtn.Location = new System.Drawing.Point(183, 286);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.loginBtn.RectWidth = 1;
            this.loginBtn.Size = new System.Drawing.Size(150, 51);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.TabStop = false;
            this.loginBtn.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.loginBtn.TipsText = "";
            this.loginBtn.BtnClick += new System.EventHandler(this.loginBtn_BtnClick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.Name = "login";
            this.Text = "智能网关";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.TextBoxEx UserName;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.TextBoxEx PassWord;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCBtnExt loginBtn;
    }
}

