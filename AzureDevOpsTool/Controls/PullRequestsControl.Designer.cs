namespace AzureDevOpsTool.Controls
{
    partial class PullRequestsControl
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
            _lblTargetRepos = new Label();
            _comboBoxRepos = new ComboBox();
            _richTextBoxResult = new RichTextBox();
            _labelTargetProj = new Label();
            _comboBoxTargetProj = new ComboBox();
            _btnExecute = new Button();
            _checkBoxOutputFile = new CheckBox();
            _textBoxOutputPath = new TextBox();
            _btnFolderBrows = new Button();
            _btnSearchCondition = new Button();
            _txtBoxSearchCondition = new TextBox();
            _lblCondition = new Label();
            SuspendLayout();
            // 
            // _lblTargetRepos
            // 
            _lblTargetRepos.AutoSize = true;
            _lblTargetRepos.Location = new Point(3, 33);
            _lblTargetRepos.Name = "_lblTargetRepos";
            _lblTargetRepos.Size = new Size(71, 15);
            _lblTargetRepos.TabIndex = 1;
            _lblTargetRepos.Text = "TargetRepos";
            // 
            // _comboBoxRepos
            // 
            _comboBoxRepos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _comboBoxRepos.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxRepos.FormattingEnabled = true;
            _comboBoxRepos.Location = new Point(91, 30);
            _comboBoxRepos.Name = "_comboBoxRepos";
            _comboBoxRepos.Size = new Size(301, 23);
            _comboBoxRepos.TabIndex = 2;
            // 
            // _richTextBoxResult
            // 
            _richTextBoxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _richTextBoxResult.Location = new Point(3, 149);
            _richTextBoxResult.Name = "_richTextBoxResult";
            _richTextBoxResult.ReadOnly = true;
            _richTextBoxResult.Size = new Size(392, 330);
            _richTextBoxResult.TabIndex = 3;
            _richTextBoxResult.Text = "";
            // 
            // _labelTargetProj
            // 
            _labelTargetProj.AutoSize = true;
            _labelTargetProj.Location = new Point(3, 9);
            _labelTargetProj.Name = "_labelTargetProj";
            _labelTargetProj.Size = new Size(82, 15);
            _labelTargetProj.TabIndex = 4;
            _labelTargetProj.Text = "TaregetProject";
            // 
            // _comboBoxTargetProj
            // 
            _comboBoxTargetProj.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _comboBoxTargetProj.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxTargetProj.FormattingEnabled = true;
            _comboBoxTargetProj.Location = new Point(91, 6);
            _comboBoxTargetProj.Name = "_comboBoxTargetProj";
            _comboBoxTargetProj.Size = new Size(301, 23);
            _comboBoxTargetProj.TabIndex = 5;
            _comboBoxTargetProj.SelectedIndexChanged += _comboBoxTargetProj_SelectedIndexChanged;
            // 
            // _btnExecute
            // 
            _btnExecute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnExecute.Location = new Point(317, 121);
            _btnExecute.Name = "_btnExecute";
            _btnExecute.Size = new Size(75, 23);
            _btnExecute.TabIndex = 6;
            _btnExecute.Text = "Execute";
            _btnExecute.UseVisualStyleBackColor = true;
            _btnExecute.Click += _btnExecute_Click;
            // 
            // _checkBoxOutputFile
            // 
            _checkBoxOutputFile.AutoSize = true;
            _checkBoxOutputFile.Location = new Point(4, 97);
            _checkBoxOutputFile.Name = "_checkBoxOutputFile";
            _checkBoxOutputFile.Size = new Size(121, 19);
            _checkBoxOutputFile.TabIndex = 7;
            _checkBoxOutputFile.Text = "Csvファイル出力する";
            _checkBoxOutputFile.UseVisualStyleBackColor = true;
            _checkBoxOutputFile.CheckedChanged += _checkBoxOutputFile_CheckedChanged;
            // 
            // _textBoxOutputPath
            // 
            _textBoxOutputPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _textBoxOutputPath.Location = new Point(125, 92);
            _textBoxOutputPath.Name = "_textBoxOutputPath";
            _textBoxOutputPath.Size = new Size(234, 23);
            _textBoxOutputPath.TabIndex = 8;
            // 
            // _btnFolderBrows
            // 
            _btnFolderBrows.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnFolderBrows.Location = new Point(365, 90);
            _btnFolderBrows.Name = "_btnFolderBrows";
            _btnFolderBrows.Size = new Size(27, 25);
            _btnFolderBrows.TabIndex = 9;
            _btnFolderBrows.Text = "...";
            _btnFolderBrows.UseVisualStyleBackColor = true;
            _btnFolderBrows.Click += _btnFolderBrows_Click;
            // 
            // _btnSearchCondition
            // 
            _btnSearchCondition.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnSearchCondition.Location = new Point(365, 61);
            _btnSearchCondition.Name = "_btnSearchCondition";
            _btnSearchCondition.Size = new Size(27, 23);
            _btnSearchCondition.TabIndex = 10;
            _btnSearchCondition.Text = "...";
            _btnSearchCondition.UseVisualStyleBackColor = true;
            _btnSearchCondition.Click += _btnSearchCondition_Click;
            // 
            // _txtBoxSearchCondition
            // 
            _txtBoxSearchCondition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _txtBoxSearchCondition.Location = new Point(56, 59);
            _txtBoxSearchCondition.Name = "_txtBoxSearchCondition";
            _txtBoxSearchCondition.ReadOnly = true;
            _txtBoxSearchCondition.Size = new Size(303, 23);
            _txtBoxSearchCondition.TabIndex = 11;
            // 
            // _lblCondition
            // 
            _lblCondition.AutoSize = true;
            _lblCondition.Location = new Point(3, 65);
            _lblCondition.Name = "_lblCondition";
            _lblCondition.Size = new Size(55, 15);
            _lblCondition.TabIndex = 12;
            _lblCondition.Text = "検索条件";
            // 
            // PullRequestsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_lblCondition);
            Controls.Add(_txtBoxSearchCondition);
            Controls.Add(_btnSearchCondition);
            Controls.Add(_btnFolderBrows);
            Controls.Add(_textBoxOutputPath);
            Controls.Add(_checkBoxOutputFile);
            Controls.Add(_btnExecute);
            Controls.Add(_comboBoxTargetProj);
            Controls.Add(_labelTargetProj);
            Controls.Add(_richTextBoxResult);
            Controls.Add(_comboBoxRepos);
            Controls.Add(_lblTargetRepos);
            Name = "PullRequestsControl";
            Size = new Size(398, 482);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lblTargetRepos;
        private ComboBox _comboBoxRepos;
        private RichTextBox _richTextBoxResult;
        private Label _labelTargetProj;
        private ComboBox _comboBoxTargetProj;
        private Button _btnExecute;
        private CheckBox _checkBoxOutputFile;
        private TextBox _textBoxOutputPath;
        private Button _btnFolderBrows;
        private Button _btnSearchCondition;
        private TextBox _txtBoxSearchCondition;
        private Label _lblCondition;
    }
}
