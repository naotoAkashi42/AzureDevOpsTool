using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDevOpsTool.Service.Wrapper
{
    internal static class GitClientWrapper
    {
        internal static IReadOnlyList<GitRepository> GetRepositories(VssConnection connection)
        {
            var client = connection.GetClient<GitHttpClient>();
            return client.GetRepositoriesAsync().Result;
        }
    }
}
