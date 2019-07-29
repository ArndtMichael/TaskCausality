using System;
using System.Threading;
using System.Threading.Tasks;

namespace IssuesAsTests
{
    /// <summary>
    ///     Implements a worker that  sequentializes work using a <see cref="SemaphoreSlim"/> with.
    /// </summary>
    public class Worker
    {
        private readonly SemaphoreSlim _semaphore;

        public Worker(string name)
        {
            this._semaphore = new SemaphoreSlim(1, 1);
        }

        public async Task DoWork(uint seconds)
        {
            try
            {
                await this._semaphore.WaitAsync();
                await Task.Delay(TimeSpan.FromSeconds(seconds));
            }
            finally
            {
                this._semaphore.Release();
            }
        }
    }
}