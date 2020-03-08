using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IImageProcessorService
    {
        (int width, int height) GetSizes(string destination);

        Task Resize(string destination, int width, int height);
    }
}
