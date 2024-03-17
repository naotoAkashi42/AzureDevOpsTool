using AzureDevOpsTool.Setting;
using System.ComponentModel;

namespace AzureDevOpsTool.View
{
    public partial class UserSettingForm : Form
    {
        internal interface INeed
        {
            bool IsValidUri(string input);
            void Save(ServiceSetting newSetting);
        }

        private readonly INeed _need;

        internal UserSettingForm(INeed need)
        {
            InitializeComponent();
            _need = need;

            _textBoxUri.Validating += _textBoxUri_Validating;
        }

        private void _textBoxUri_Validating(object? sender, CancelEventArgs e)
        {
            if (!_need.IsValidUri(_textBoxUri.Text))
            {
                MessageBox.Show("Invalid Uri!");
                _textBoxUri.Text = string.Empty;
                e.Cancel = true;
            }
        }

        private void _buttonOk_Click(object sender, EventArgs e)
        {
            var newSetting = new ServiceSetting(_textBoxUri.Text, _textBoxPAT.Text);
            _need.Save(newSetting);
        }
    }
}
