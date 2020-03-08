using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IWebClientService
    {
        Task DownloadFileTaskAsync(string address, string fileName);
    }
}
