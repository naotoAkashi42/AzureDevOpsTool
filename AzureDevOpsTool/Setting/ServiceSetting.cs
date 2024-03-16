namespace AzureDevOpsTool.Setting
{
    internal class ServiceSetting(string uri, string personalAccessToken)
    {
        public string Uri { get; init; } = uri;
        public string PersonalAccessToken { get; init; } = personalAccessToken;
    }
}
