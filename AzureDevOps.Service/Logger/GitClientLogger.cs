using AzureDevOps.Service;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using System.Text;

namespace AzureDevOpsTool.Service.Logger
{
    internal static class GitClientLogger
    {
        public static string GetRepositoryInfo(GitServiceContext context)
        {
            var connection = context.Connection;
            var gitClient = connection.GetClient<GitHttpClient>();
            var repositories = gitClient.GetRepositoriesAsync().Result;

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
    }
}
