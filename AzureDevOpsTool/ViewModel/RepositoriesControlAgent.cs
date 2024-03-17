using AzureDevOps.Service;
using AzureDevOpsTool.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDevOpsTool.ViewModel
{
    internal class RepositoriesControlAgent : RepositoriesInfoControl.INeed
    {
        private readonly GitServiceContext _context;
        public RepositoriesControlAgent(GitServiceContext context)
        {
            _context = context;
        }

        public string GetRepositoriesInfoLog()
            => ServiceEntry.GetRepositriesInfoLog(_context);
    }
}
