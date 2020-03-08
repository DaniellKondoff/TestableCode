using Blog.Services;
using System.Threading.Tasks;

namespace Blog.Test.Fake
{
    public class FakeWebClientService : IWebClientService
    {
        public bool FileDownloaded { get; private set; }

        public string DownloadDestination { get; private set; }
        public Task DownloadFileTaskAsync(string address, string fileName)
        {
            this.FileDownloaded = true;
            this.DownloadDestination = fileName;

            return Task.CompletedTask;
        }
    }
}
