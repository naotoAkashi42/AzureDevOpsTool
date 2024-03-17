using AzureDevOps.Service;
using AzureDevOpsTool.Controls;
using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.TeamFoundation.SourceControl.WebApi;

namespace AzureDevOpsTool.ViewModel
{
    internal class PullrequestsControlAgent : PullRequestsControl.INeed
    {
        private readonly GitServiceContext _context;
        public PullrequestsControlAgent(GitServiceContext context)
        {
            _context = context;
        }

        public string[] GetTragetProjectCandidates()
        {
            var client = _context.Connection.GetClient<ProjectHttpClient>();
            return client.GetProjects().Result.Select(p => p.Name).ToArray();
        }

        public string[] GetTargetReposCandidates(string projectName)
        {
            var client = _context.Connection.GetClient<GitHttpClient>();
            return client.GetRepositoriesAsync(projectName).Result.Select(r => r.Name).ToArray();
        }

        public string GetPullRequestInfoLog(string targetRepos)
           => ServiceEntry.GetPullRequestsInfoLog(targetRepos, _context);
    }
}
