using AzureDevOpsTool.Setting;
using AzureDevOpsTool.Service;
using AzureDevOps.Service;

namespace AzureDevOpsTool
{
    public partial class MainForm : Form
    {
        private AppSetting _setting;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _setting = AppSettingManager.LoadSetting();
        }

        private void _btnExecute_Click(object sender, EventArgs e)
        {
            var context = new GitServiceContext(_setting.Uri, _setting.PersonalAccessToken);
            var result = ServiceEntry.GetRepositriesInfo(context);
        }
    }
}
