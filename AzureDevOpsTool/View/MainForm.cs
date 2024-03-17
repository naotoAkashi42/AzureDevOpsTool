using AzureDevOpsTool.Setting;
using AzureDevOpsTool.Design;

namespace AzureDevOpsTool.View
{
    public partial class MainForm : Form
    {
        internal interface INeed
        {
            ServiceSetting LoadServiceSettings();
            string[] GetServiceEntryTypeComboCandidates();
            void UpdatePanelContent(ServiceEntryType type, ServiceSetting setting, Panel panel);
            UserSettingForm.INeed UserSettingFormNeed { get; }
        }

        private readonly INeed _need;
        internal MainForm(INeed need)
        {
            InitializeComponent();
            _need = need;

            InitServiceEntryComboBox();
        }

        private void _btnSetting_Click(object sender, EventArgs e)
        {
            using var f = new UserSettingForm(_need.UserSettingFormNeed);
            f.ShowDialog();
        }

        private void InitServiceEntryComboBox()
        {
            var candidates = _need.GetServiceEntryTypeComboCandidates();
            _comboBoxServieType.Items.AddRange(candidates);
        }

        private void _comboBoxServieType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serviceSetting = _need.LoadServiceSettings();
            var type = (ServiceEntryType)(_comboBoxServieType.SelectedIndex);
            _need.UpdatePanelContent(type, serviceSetting, _panel);
        }
    }
}
