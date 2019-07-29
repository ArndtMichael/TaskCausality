using System.Threading.Tasks;
using Xunit;

namespace IssuesAsTests
{
    public class SemaphoreCausalityIssues
    {
        /// <summary>
        /// This tests illustrates that waiting of a tasks/semaphore is not visible in debbugging and analyzing scenarios.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Semaphore_WaitOnSemaphore_SeeWhoWaitsWhere()
        {
            var tasks = new Task[5];
            var worker = new Worker("MyWorker");
            uint secondsPerWork = 2;

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = worker.DoWork(secondsPerWork);
            }

            await Task.WhenAll(tasks);
        }
    }
}