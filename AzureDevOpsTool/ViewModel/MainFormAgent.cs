using AzureDevOps.Service;
using AzureDevOpsTool.Design;
using AzureDevOpsTool.Setting;
using AzureDevOpsTool.View;

namespace AzureDevOpsTool.ViewModel
{
    internal class MainFormAgent : MainForm.INeed
    {
        public ServiceSetting AppSettings => ServiceSettingManager.LoadSetting();

        public string ExecuteService(ServiceEntryType type, ServiceSetting setting)
        {
            switch (type)
            {
                case ServiceEntryType.RepositreisInfo:
                    {
                        var context = new GitServiceContext(setting.Uri, setting.PersonalAccessToken);
                        return ServiceEntry.GetRepositriesInfoLog(context);
                    }
                default: return string.Empty;
            }
        }

        public string[] GetServiceEntryTypeComboCandidates()
        {
           return  Enum.GetValues<ServiceEntryType>()
                       .Select(s => s.ToDispString())
                       .Where(s => !string.IsNullOrEmpty(s))
                       .ToArray();
        }
    }
}
