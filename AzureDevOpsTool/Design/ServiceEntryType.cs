using System.Runtime.CompilerServices;

namespace AzureDevOpsTool.Design
{
    internal enum ServiceEntryType
    {
        RepositoreisInfo,
        PullRequestInfo,
    }

    internal static class ServiceEntryTypeExtension
    {
        private readonly static Dictionary<ServiceEntryType, string> _stringDic = new()
        {
            { ServiceEntryType.RepositoreisInfo, "Repositories Infomations" },
            { ServiceEntryType.PullRequestInfo, "PullRequests Infomations" },
        };

        public static string ToDispString(this ServiceEntryType type) => _stringDic[type];
    }
}
