using System;
using System.Threading.Tasks;
using Xunit;

namespace IssuesAsTests
{
    public class TaskViewIssues
    {
        [Fact]
        public async Task Await_TaskDelay_SeeWhereWeWait()
        {
            // Break and try to find this wait.
            await Task.Delay(TimeSpan.FromMinutes(1));
        }
    }
}
