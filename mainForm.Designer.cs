
namespace clipTextChange
{
    partial class mainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.changeEnable = new System.Windows.Forms.CheckBox();
            this.addnewlineCode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // changeEnable
            // 
            this.changeEnable.AutoSize = true;
            this.changeEnable.Location = new System.Drawing.Point(12, 12);
            this.changeEnable.Name = "changeEnable";
            this.changeEnable.Size = new System.Drawing.Size(324, 22);
            this.changeEnable.TabIndex = 0;
            this.changeEnable.Text = "クリップボードのテキスト変更を有効にする";
            this.changeEnable.UseVisualStyleBackColor = true;
            // 
            // addnewlineCode
            // 
            this.addnewlineCode.AutoSize = true;
            this.addnewlineCode.Location = new System.Drawing.Point(12, 41);
            this.addnewlineCode.Name = "addnewlineCode";
            this.addnewlineCode.Size = new System.Drawing.Size(211, 22);
            this.addnewlineCode.TabIndex = 1;
            this.addnewlineCode.Text = ".の後に改行コードを追加";
            this.addnewlineCode.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 78);
            this.Controls.Add(this.addnewlineCode);
            this.Controls.Add(this.changeEnable);
            this.Name = "mainForm";
            this.Text = "ClipChanger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox changeEnable;
        private System.Windows.Forms.CheckBox addnewlineCode;
    }
}

