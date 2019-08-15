namespace 猜拳
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnshitou = new System.Windows.Forms.Button();
            this.btnjiandao = new System.Windows.Forms.Button();
            this.btnbu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(37, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 12);
            this.label.TabIndex = 0;
            this.label.Text = "玩家";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "电脑";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(310, 38);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(41, 12);
            this.lblComputer.TabIndex = 2;
            this.lblComputer.Text = "label3";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(113, 38);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(41, 12);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "label4";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(182, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label5";
            // 
            // btnshitou
            // 
            this.btnshitou.Location = new System.Drawing.Point(39, 209);
            this.btnshitou.Name = "btnshitou";
            this.btnshitou.Size = new System.Drawing.Size(75, 23);
            this.btnshitou.TabIndex = 5;
            this.btnshitou.Text = "石头";
            this.btnshitou.UseVisualStyleBackColor = true;
            this.btnshitou.Click += new System.EventHandler(this.btnshitou_Click);
            // 
            // btnjiandao
            // 
            this.btnjiandao.Location = new System.Drawing.Point(161, 209);
            this.btnjiandao.Name = "btnjiandao";
            this.btnjiandao.Size = new System.Drawing.Size(75, 23);
            this.btnjiandao.TabIndex = 6;
            this.btnjiandao.Text = "剪刀";
            this.btnjiandao.UseVisualStyleBackColor = true;
            this.btnjiandao.Click += new System.EventHandler(this.btnshitou_Click);
            // 
            // btnbu
            // 
            this.btnbu.Location = new System.Drawing.Point(276, 209);
            this.btnbu.Name = "btnbu";
            this.btnbu.Size = new System.Drawing.Size(75, 23);
            this.btnbu.TabIndex = 7;
            this.btnbu.Text = "布";
            this.btnbu.UseVisualStyleBackColor = true;
            this.btnbu.Click += new System.EventHandler(this.btnshitou_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 329);
            this.Controls.Add(this.btnbu);
            this.Controls.Add(this.btnjiandao);
            this.Controls.Add(this.btnshitou);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnshitou;
        private System.Windows.Forms.Button btnjiandao;
        private System.Windows.Forms.Button btnbu;
    }
}

