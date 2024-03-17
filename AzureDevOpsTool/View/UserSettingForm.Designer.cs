namespace AzureDevOpsTool.View
{
    partial class UserSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _labelTargetUri = new Label();
            _textBoxUri = new TextBox();
            _lblPersonalAccessToken = new Label();
            _textBoxPAT = new TextBox();
            _buttonOk = new Button();
            _btnCancel = new Button();
            SuspendLayout();
            // 
            // _labelTargetUri
            // 
            _labelTargetUri.AutoSize = true;
            _labelTargetUri.Location = new Point(12, 9);
            _labelTargetUri.Name = "_labelTargetUri";
            _labelTargetUri.Size = new Size(22, 15);
            _labelTargetUri.TabIndex = 0;
            _labelTargetUri.Text = "Uri";
            // 
            // _textBoxUri
            // 
            _textBoxUri.Location = new Point(40, 6);
            _textBoxUri.Name = "_textBoxUri";
            _textBoxUri.Size = new Size(284, 23);
            _textBoxUri.TabIndex = 1;
            // 
            // _lblPersonalAccessToken
            // 
            _lblPersonalAccessToken.AutoSize = true;
            _lblPersonalAccessToken.Location = new Point(12, 51);
            _lblPersonalAccessToken.Name = "_lblPersonalAccessToken";
            _lblPersonalAccessToken.Size = new Size(119, 15);
            _lblPersonalAccessToken.TabIndex = 2;
            _lblPersonalAccessToken.Text = "PersonalAccessToken";
            // 
            // _textBoxPAT
            // 
            _textBoxPAT.Location = new Point(40, 69);
            _textBoxPAT.Name = "_textBoxPAT";
            _textBoxPAT.Size = new Size(284, 23);
            _textBoxPAT.TabIndex = 3;
            // 
            // _buttonOk
            // 
            _buttonOk.Location = new Point(181, 117);
            _buttonOk.Name = "_buttonOk";
            _buttonOk.Size = new Size(65, 23);
            _buttonOk.TabIndex = 4;
            _buttonOk.Text = "Ok";
            _buttonOk.UseVisualStyleBackColor = true;
            _buttonOk.Click += _buttonOk_Click;
            // 
            // _btnCancel
            // 
            _btnCancel.Location = new Point(252, 117);
            _btnCancel.Name = "_btnCancel";
            _btnCancel.Size = new Size(65, 23);
            _btnCancel.TabIndex = 5;
            _btnCancel.Text = "Cancel";
            _btnCancel.UseVisualStyleBackColor = true;
            _btnCancel.Click += _btnCancel_Click;
            // 
            // UserSettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 152);
            Controls.Add(_btnCancel);
            Controls.Add(_buttonOk);
            Controls.Add(_textBoxPAT);
            Controls.Add(_lblPersonalAccessToken);
            Controls.Add(_textBoxUri);
            Controls.Add(_labelTargetUri);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserSettingForm";
            Text = "UserSettingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _labelTargetUri;
        private TextBox _textBoxUri;
        private Label _lblPersonalAccessToken;
        private TextBox _textBoxPAT;
        private Button _buttonOk;
        private Button _btnCancel;
    }
}