namespace PVZ_Plugin
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.SunLable = new System.Windows.Forms.Label();
            this.Sun = new System.Windows.Forms.TextBox();
            this.SunBind = new System.Windows.Forms.CheckBox();
            this.MessageLable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SunLable
            // 
            this.SunLable.AutoSize = true;
            this.SunLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SunLable.Location = new System.Drawing.Point(28, 30);
            this.SunLable.Name = "SunLable";
            this.SunLable.Size = new System.Drawing.Size(69, 20);
            this.SunLable.TabIndex = 0;
            this.SunLable.Text = "阳光：";
            // 
            // Sun
            // 
            this.Sun.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sun.Location = new System.Drawing.Point(93, 24);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(116, 34);
            this.Sun.TabIndex = 1;
            this.Sun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sun_KeyDown);
            // 
            // SunBind
            // 
            this.SunBind.AutoSize = true;
            this.SunBind.Location = new System.Drawing.Point(225, 33);
            this.SunBind.Name = "SunBind";
            this.SunBind.Size = new System.Drawing.Size(59, 19);
            this.SunBind.TabIndex = 2;
            this.SunBind.Text = "锁定";
            this.SunBind.UseVisualStyleBackColor = true;
            // 
            // MessageLable
            // 
            this.MessageLable.AutoSize = true;
            this.MessageLable.Location = new System.Drawing.Point(29, 72);
            this.MessageLable.Name = "MessageLable";
            this.MessageLable.Size = new System.Drawing.Size(0, 15);
            this.MessageLable.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 108);
            this.Controls.Add(this.MessageLable);
            this.Controls.Add(this.SunBind);
            this.Controls.Add(this.Sun);
            this.Controls.Add(this.SunLable);
            this.Name = "Main";
            this.Text = "植物大战僵尸修改器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SunLable;
        private System.Windows.Forms.TextBox Sun;
        private System.Windows.Forms.CheckBox SunBind;
        private System.Windows.Forms.Label MessageLable;
        private System.Windows.Forms.Timer timer1;
    }
}

