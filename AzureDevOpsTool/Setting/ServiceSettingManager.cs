namespace AzureDevOpsTool.Setting
{
    internal static class ServiceSettingManager
    {
        internal static ServiceSetting LoadSetting()
        {
            var uri = Properties.Settings.Default["Uri"].ToString();
            var personalAccessToken = Properties.Settings.Default["PersonalAccessToken"].ToString();

            if (uri == null || personalAccessToken == null)
            {
                return new ServiceSetting(string.Empty, string.Empty);
            }

            return new ServiceSetting(uri, personalAccessToken);
        }

        internal static void SaveSetting(ServiceSetting newSetting)
        {
            Properties.Settings.Default["Uri"] = newSetting.Uri;
            Properties.Settings.Default["PersonalAccessToken"] = newSetting.PersonalAccessToken;
            Properties.Settings.Default.Save();
        }
    }
}
