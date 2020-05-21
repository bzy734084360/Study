namespace _06字典英汉翻译
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btntranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(47, 12);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(178, 129);
            this.txtBox.TabIndex = 0;
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(47, 172);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(178, 129);
            this.txtBoxResult.TabIndex = 1;
            // 
            // btntranslate
            // 
            this.btntranslate.Location = new System.Drawing.Point(264, 137);
            this.btntranslate.Name = "btntranslate";
            this.btntranslate.Size = new System.Drawing.Size(75, 23);
            this.btntranslate.TabIndex = 2;
            this.btntranslate.Text = "翻译";
            this.btntranslate.UseVisualStyleBackColor = true;
            this.btntranslate.Click += new System.EventHandler(this.Btntranslate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 333);
            this.Controls.Add(this.btntranslate);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btntranslate;
    }
}

