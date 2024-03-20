using AzureDevOpsTool.Service.Git;
using Microsoft.TeamFoundation.SourceControl.WebApi;

namespace AzureDevOps.Service
{
    public static class ServiceEntry
    {
        #region Git Service


        public static string GetRepositriesInfoLog(GitServiceContext gitClientContext)
            => GitInfoAccessor.GetRepositriesInfo(gitClientContext);

        public static IReadOnlyList<GitPullRequest> GetPullRequestsInfo(
                                string targetReposName,
                                PullRequestStatus status,
                                GitServiceContext gitServiceContext)
            => GitInfoAccessor.GetPullRequestsInfo(targetReposName, status, gitServiceContext);
        #endregion
    }
}
