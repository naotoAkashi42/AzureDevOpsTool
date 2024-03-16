using AzureDevOpsTool.Setting;
using AzureDevOpsTool.Design;

namespace AzureDevOpsTool.View
{
    public partial class MainForm : Form
    {
        internal interface INeed
        {
            ServiceSetting AppSettings { get; }
            string[] GetServiceEntryTypeComboCandidates();
            string ExecuteService(ServiceEntryType type, ServiceSetting setting);
        }

        private readonly INeed _need;
        private ServiceSetting _setting;
        internal MainForm(INeed need)
        {
            InitializeComponent();
            _need = need;

            InitServiceEntryComboBox();
            _setting = _need.AppSettings;
        }

        private void _btnExecute_Click(object sender, EventArgs e)
        {
            var type = (ServiceEntryType)_comboBoxServieType.SelectedIndex;
            _richTextBoxResult.Text = _need.ExecuteService(type, _setting);
        }

        private void InitServiceEntryComboBox()
        {
            var candidates = _need.GetServiceEntryTypeComboCandidates();
            _comboBoxServieType.Items.AddRange(candidates);
        }
    }
}
