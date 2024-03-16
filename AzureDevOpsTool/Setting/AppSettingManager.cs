namespace AzureDevOpsTool.Setting
{
    internal static class AppSettingManager
    {
        internal static AppSetting LoadSetting()
        {
            var uri = Properties.Settings.Default["Uri"].ToString();
            var personalAccessToken = Properties.Settings.Default["PersonalAccessToken"].ToString();

            if (uri == null || personalAccessToken == null)
            {
                return new AppSetting(string.Empty, string.Empty);
            }

            return new AppSetting(uri, personalAccessToken);
        }

        internal static void SaveSetting(AppSetting newSetting)
        {
            Properties.Settings.Default["Uri"] = newSetting.Uri;
            Properties.Settings.Default["PersonalAccessToken"] = newSetting.PersonalAccessToken;
            Properties.Settings.Default.Save();
        }
    }
}
