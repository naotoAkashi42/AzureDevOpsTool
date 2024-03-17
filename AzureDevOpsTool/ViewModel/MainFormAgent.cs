using AzureDevOps.Service;
using AzureDevOpsTool.Controls;
using AzureDevOpsTool.Design;
using AzureDevOpsTool.Setting;
using AzureDevOpsTool.View;

namespace AzureDevOpsTool.ViewModel
{
    internal class MainFormAgent : MainForm.INeed
    {
        public ServiceSetting LoadServiceSettings() => ServiceSettingManager.LoadSetting();

        public UserSettingForm.INeed UserSettingFormNeed => new UserSettingFormAgent();

        public string[] GetServiceEntryTypeComboCandidates()
        {
           return  Enum.GetValues<ServiceEntryType>()
                       .Select(s => s.ToDispString())
                       .Where(s => !string.IsNullOrEmpty(s))
                       .ToArray();
        }

        public void UpdatePanelContent(ServiceEntryType type, ServiceSetting serviceSetting, Panel panel)
        {
            ClearPanelContent(panel);

            var context = new GitServiceContext(serviceSetting.Uri, serviceSetting.PersonalAccessToken);

            var control = ServiceControlFactory.Create(type, context);
            panel.Controls.Add(control);
        }

        private void ClearPanelContent(Panel panel)
        {
            foreach(Control c in panel.Controls)
            {
                panel.Controls.Remove(c);
            }
        }
    }
}
