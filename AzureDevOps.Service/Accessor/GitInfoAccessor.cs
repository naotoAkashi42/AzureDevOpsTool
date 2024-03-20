using AzureDevOps.Service;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using System.Text;

namespace AzureDevOpsTool.Service.Git
{
    internal static class GitInfoAccessor
    {
        public static string GetRepositriesInfo(GitServiceContext context)
        {
            var repositories = GetRepositories(context);

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Repositories Info");
            foreach ( var repository in repositories )
            {
                stringBuilder.AppendLine($"\trepos name: {repository.Name}");
                stringBuilder.AppendLine($"\trepos id: {repository.Id}");
                stringBuilder.AppendLine($"\trepos url: {repository.Url}");
                stringBuilder.AppendLine(string.Empty);
            }
            return  stringBuilder.ToString();
        }

        public static IReadOnlyList<GitPullRequest> GetPullRequestsInfo(
                                string targetReposName, 
                                PullRequestStatus status, 
                                GitServiceContext context)
        {
            var repositories = GetRepositories(context).ToList();
            var targetRepos = repositories.Find(r => r.Name.Equals(targetReposName));
            if (targetRepos == null) return new List<GitPullRequest>();

            var gitClient = context.Connection.GetClient<GitHttpClient>();
            var searchCreteria = new GitPullRequestSearchCriteria()
            {
                Status = status,
            };
            return gitClient.GetPullRequestsAsync(targetRepos.Id, searchCreteria).Result;
        }

        public static IReadOnlyList<GitRepository> GetRepositories(GitServiceContext context)
        {
            var connection = context.Connection;
            var client = connection.GetClient<GitHttpClient>();
            return client.GetRepositoriesAsync().Result;
        }
    }
}
