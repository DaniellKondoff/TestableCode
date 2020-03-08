using System.Net;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class WebClientService : IWebClientService
    {
        private readonly WebClient webClient;

        public WebClientService()
        {
            this.webClient = new WebClient();
        }

        public async Task DownloadFileTaskAsync(string address, string fileName)
        {
            await this.webClient.DownloadFileTaskAsync(address, fileName);
        }
    }
}
