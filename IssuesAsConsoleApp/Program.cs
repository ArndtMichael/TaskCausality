using System;
using System.Threading.Tasks;

namespace IssuesAsConsoleApp
{
    class Task_TaskDelay_SeeWhereWeWait
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(TimeSpan.FromMinutes(1));
        }
    }
}
