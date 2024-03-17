using AzureDevOps.Service;
using AzureDevOpsTool.Controls;
using AzureDevOpsTool.Design;

namespace AzureDevOpsTool.ViewModel
{
    internal static class ServiceControlFactory
    {
        public static Control Create(ServiceEntryType type, GitServiceContext context)
        {
            switch (type)
            {
                case ServiceEntryType.RepositoreisInfo:
                    {
                        var need = new RepositoriesControlAgent(context);
                        return new RepositoriesInfoControl(need);
                    }
                case ServiceEntryType.PullRequestInfo:
                    {
                        var need = new PullrequestsControlAgent(context);
                        return new PullRequestsControl(need);
                    }
                default : throw new NotSupportedException();
            }
        }
    }
}
