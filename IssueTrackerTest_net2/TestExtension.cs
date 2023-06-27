using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codice.Client.IssueTracker.IssueTrackerTest
{
    public class TestExtension : IPlasticIssueTrackerExtension
    {
        void IPlasticIssueTrackerExtension.Connect()
        {
            throw new NotImplementedException();
        }

        void IPlasticIssueTrackerExtension.Disconnect()
        {
            throw new NotImplementedException();
        }

        string IPlasticIssueTrackerExtension.GetExtensionName()
        {
            throw new NotImplementedException();
        }

        List<PlasticTask> IPlasticIssueTrackerExtension.GetPendingTasks()
        {
            throw new NotImplementedException();
        }

        List<PlasticTask> IPlasticIssueTrackerExtension.GetPendingTasks(string assignee)
        {
            throw new NotImplementedException();
        }

        PlasticTask IPlasticIssueTrackerExtension.GetTaskForBranch(string fullBranchName)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, PlasticTask> IPlasticIssueTrackerExtension.GetTasksForBranches(List<string> fullBranchNames)
        {
            throw new NotImplementedException();
        }

        List<PlasticTask> IPlasticIssueTrackerExtension.LoadTasks(List<string> taskIds)
        {
            throw new NotImplementedException();
        }

        void IPlasticIssueTrackerExtension.LogCheckinResult(PlasticChangeset changeset, List<PlasticTask> tasks)
        {
            throw new NotImplementedException();
        }

        void IPlasticIssueTrackerExtension.MarkTaskAsOpen(string taskId, string assignee)
        {
            throw new NotImplementedException();
        }

        void IPlasticIssueTrackerExtension.OpenTaskExternally(string taskId)
        {
            throw new NotImplementedException();
        }

        bool IPlasticIssueTrackerExtension.TestConnection(IssueTrackerConfiguration configuration)
        {
            throw new NotImplementedException();
        }

        void IPlasticIssueTrackerExtension.UpdateLinkedTasksToChangeset(PlasticChangeset changeset, List<string> tasks)
        {
            throw new NotImplementedException();
        }
    }
}
