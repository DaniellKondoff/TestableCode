using Blog.Services;
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

            var imageService = new ImageService();

            //Act
            var (width, height) = imageService.CalculateOptimalSize(resizeSize, resizeSize, originalSize, originalSize);

            //Assert
            Assert.Equal(minSize, width);
            Assert.Equal(minSize, height);
        }
    }
}
