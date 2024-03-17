using AzureDevOpsTool.Setting;
using AzureDevOpsTool.Design;

namespace AzureDevOpsTool.View
{
    public partial class MainForm : Form
    {
        internal interface INeed
        {
            ServiceSetting ServiceSettings { get; }
            string[] GetServiceEntryTypeComboCandidates();
            void UpdatePanelContent(ServiceEntryType type, ServiceSetting setting, Panel panel);
        }

        private readonly INeed _need;
        private ServiceSetting _setting;
        internal MainForm(INeed need)
        {
            InitializeComponent();
            _need = need;

            InitServiceEntryComboBox();
            _setting = _need.ServiceSettings;
        }

        private void _btnSetting_Click(object sender, EventArgs e)
        {
            // TODO ê›íËïœçXópUI
        }

        private void InitServiceEntryComboBox()
        {
            var candidates = _need.GetServiceEntryTypeComboCandidates();
            _comboBoxServieType.Items.AddRange(candidates);
        }

        private void _comboBoxServieType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = (ServiceEntryType)(_comboBoxServieType.SelectedIndex);
            _need.UpdatePanelContent(type, _setting, _panel);
        }
    }
}
