using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codice.Client.IssueTracker.IssueTrackerTest
{
    public class TestExtensionFactory : IPlasticIssueTrackerExtensionFactory
    {
        public IssueTrackerConfiguration GetConfiguration(IssueTrackerConfiguration storedConfiguration)
        {
            throw new NotImplementedException();
        }

        public IPlasticIssueTrackerExtension GetIssueTrackerExtension(IssueTrackerConfiguration configuration)
        {
            throw new NotImplementedException();
        }

        public string GetIssueTrackerName()
        {
            throw new NotImplementedException();
        }
    }
}
