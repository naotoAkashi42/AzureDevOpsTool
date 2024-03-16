using AzureDevOpsTool.Service.Logger;

namespace AzureDevOps.Service
{
    public static class ServiceEntry
    {
        #region Git Service
        public static string GetRepositriesInfoLog(GitServiceContext gitClientContext)
            => GitClientLogger.GetRepositriesInfo(gitClientContext);

        public static string GetPullRequestsInfoLog(string targetReposName, 
                                                    GitServiceContext gitServiceContext)
            => GitClientLogger.GetPullRequestsInfo(targetReposName, gitServiceContext);
        #endregion
    }
}
