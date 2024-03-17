using AzureDevOpsTool.Setting;
using System.ComponentModel;

namespace AzureDevOpsTool.View
{
    public partial class UserSettingForm : Form
    {
        internal interface INeed
        {
            ServiceSetting Load();
            void Save(ServiceSetting newSetting);
            bool IsValidUri(string input);
        }

        private readonly INeed _need;

        internal UserSettingForm(INeed need)
        {
            InitializeComponent();
            _need = need;

            var setting = _need.Load();
            _textBoxUri.Text = setting.Uri;
            _textBoxPAT.Text = setting.PersonalAccessToken;

            _textBoxUri.Validating += _textBoxUri_Validating;
            _textBoxPAT.Validating += _textBoxPAT_Validating;
        }

        private void _textBoxPAT_Validating(object? sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(_textBoxPAT.Text)) return;

            MessageBox.Show("Invalid PAT");
            e.Cancel = true;
            return;
        }

        private void _textBoxUri_Validating(object? sender, CancelEventArgs e)
        {
            if (_need.IsValidUri(_textBoxUri.Text)) return;

            MessageBox.Show("Invalid Uri!");
            _textBoxUri.Text = string.Empty;
            e.Cancel = true;
            return;
        }

        private void _buttonOk_Click(object sender, EventArgs e)
        {
            var newSetting = new ServiceSetting(_textBoxUri.Text, _textBoxPAT.Text);
            _need.Save(newSetting);
            this.Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   
