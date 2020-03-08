using Blog.Services;
using System.Threading.Tasks;

namespace Blog.Test.Fake
{
    public class FakeImageProcessorService : IImageProcessorService
    {
        public bool ImageResized { get; private set; }
        public string ImageDestination { get; private set; }
        public (int width, int height) GetSizes(string destination)
        {
            return (1000, 1000);
        }

        public Task Resize(string destination, int width, int height)
        {
            ImageResized = true;
            ImageDestination = destination;

            return Task.CompletedTask;
        }
    }
}
