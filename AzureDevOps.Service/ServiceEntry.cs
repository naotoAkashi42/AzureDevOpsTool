using AzureDevOpsTool.Service.Logger;

namespace AzureDevOps.Service
{
    public static class ServiceEntry
    {
        public static string GetRepositriesInfoLog(GitServiceContext gitClientContext)
            => GitClientLogger.GetRepositriesInfo(gitClientContext);
    }
}
