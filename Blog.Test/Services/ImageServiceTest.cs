using Blog.Services;
using Blog.Test.Fake;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test.Services
{
    public class ImageServiceTest
    {
        [Fact]
        public void CalculateOptimalSizeShouldReturnMinSizeWhenSizeIsLessThanAllowedMinimum()
        {
            //Arenge
            const int minSize = 100;
            const int originalSize = 200;
            const int resizeSize = 50;

            var imageService = new ImageService(null, null);

            //Act
            var (width, height) = imageService.CalculateOptimalSize(resizeSize, resizeSize, originalSize, originalSize);

            //Assert
            Assert.Equal(minSize, width);
            Assert.Equal(minSize, height);
        }

        [Fact]
        public async Task UpdateImageShouldDownloadImageAndResizeItToCorectDestitnation()
        {
            //Arenge
            const string imageUrl = "TestImageUrl";
            const string destination = "TestDestination";
            const int size = 200;

            var webClientService = new FakeWebClientService();
            var imageProcessorService = new FakeImageProcessorService();
            var imageService = new ImageService(webClientService, imageProcessorService);

            //Act
            await imageService.UpdateImage(imageUrl, destination, size, size);

            //Assert
            Assert.True(webClientService.FileDownloaded);
            Assert.Equal($"{destination}.jpg", webClientService.DownloadDestination);
            Assert.True(imageProcessorService.ImageResized);
            Assert.Equal($"{destination}_optimized.jpg", imageProcessorService.ImageDestination);
        }
    }
}
