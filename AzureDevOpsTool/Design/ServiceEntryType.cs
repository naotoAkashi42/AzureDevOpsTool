using System.Runtime.CompilerServices;

namespace AzureDevOpsTool.Design
{
    internal enum ServiceEntryType
    {
        RepositreisInfo,
    }

    internal static class ServiceEntryTypeExtension
    {
        private readonly static Dictionary<ServiceEntryType, string> _stringDic = new()
        {
            { ServiceEntryType.RepositreisInfo, "Repositries Infomations" },
        };

        public static string ToDispString(this ServiceEntryType type) => _stringDic[type];
    }
}
