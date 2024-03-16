using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

namespace AzureDevOps.Service
{
    public class GitServiceContext(string uri, string personalAccessToken)
    {
        public VssConnection Connection { get; init; }
            = new VssConnection(new Uri(uri), new VssBasicCredential(string.Empty, personalAccessToken));
    }
}
