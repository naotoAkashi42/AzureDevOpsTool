using AzureDevOps.Service;
using AzureDevOpsTool.Service.Wrapper;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using System.Text;

namespace AzureDevOpsTool.Service.Logger
{
    internal static class GitClientLogger
    {
        public static string GetRepositriesInfo(GitServiceContext context)
        {
            var repositories = GitClientWrapper.GetRepositories(context.Connection);

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

        public static string GetPullRequestsInfo(string targetReposName, GitServiceContext context)
        {
            var repositories = GitClientWrapper.GetRepositories(context.Connection).ToList();
            var targetRepos = repositories.Find(r => r.Name.Equals(targetReposName));
            if (targetRepos == null) return string.Empty;

            var gitClient = context.Connection.GetClient<GitHttpClient>();
            var searchCreteria = new GitPullRequestSearchCriteria()
            {
                Status = PullRequestStatus.Completed,
            };
            var pullRequests = gitClient.GetPullRequestsAsync(targetRepos.Id, searchCreteria).Result;

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Pull Requests Info");
            var header = $"Title(Id)\tCreatedBy\tCreateDate\t";
            stringBuilder.AppendLine(header);
            foreach(var pr in pullRequests)
            {
                stringBuilder.AppendLine($"{pr.Title}({pr.PullRequestId})\t{pr.CreatedBy.DisplayName}\t{pr.CreationDate}");
            }
            return stringBuilder.ToString();    
        }
    }
}
