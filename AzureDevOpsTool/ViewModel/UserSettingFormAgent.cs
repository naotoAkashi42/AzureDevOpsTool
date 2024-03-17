using AzureDevOpsTool.Setting;
using AzureDevOpsTool.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDevOpsTool.ViewModel
{
    internal class UserSettingFormAgent : UserSettingForm.INeed
    {
        public bool IsValidUri(string input)
            => Uri.IsWellFormedUriString(input, UriKind.Absolute);

        public void Save(ServiceSetting newSetting)
            =>  ServiceSettingManager.SaveSetting(newSetting);
    }
}
