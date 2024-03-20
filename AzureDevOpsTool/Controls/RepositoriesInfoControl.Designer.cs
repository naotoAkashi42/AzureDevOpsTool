namespace AzureDevOpsTool.Controls
{
    partial class RepositoriesInfoControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            _btnExecute = new Button();
            _richTextBoxResult = new RichTextBox();
            SuspendLayout();
            // 
            // _btnExecute
            // 
            _btnExecute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnExecute.Location = new Point(72, 3);
            _btnExecute.Name = "_btnExecute";
            _btnExecute.Size = new Size(75, 23);
            _btnExecute.TabIndex = 0;
            _btnExecute.Text = "Execute";
            _btnExecute.UseVisualStyleBackColor = true;
            _btnExecute.Click += _btnExecute_Click;
            // 
            // _richTextBoxResult
            // 
            _richTextBoxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _richTextBoxResult.Location = new Point(3, 32);
            _richTextBoxResult.Name = "_richTextBoxResult";
            _richTextBoxResult.ReadOnly = true;
            _richTextBoxResult.Size = new Size(144, 115);
            _richTextBoxResult.TabIndex = 1;
            _richTextBoxResult.Text = "";
            // 
            // RepositoriesInfoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_richTextBoxResult);
            Controls.Add(_btnExecute);
            Name = "RepositoriesInfoControl";
            ResumeLayout(false);
        }

        #endregion

        private Button _btnExecute;
        private RichTextBox _richTextBoxResult;
    }
}
