using Blog.Controllers;
using Blog.Test.Extensions;
using Blog.Test.Fake;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test.Controllers
{
    public class UsersControllerTest
    {
        [Fact]
        public async Task NullPictureUrlShouldReturnBadRequest()
        {
            var usersController = new UsersController(null, null);

            var result = await usersController.ChangeProfilePicture(null);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task ChangeProfilePictureWithNonNullPicUrlShouldReturnOk()
        {
            var imageService = new FakeImageService();
            var usersController = new UsersController(imageService, null).WithTestUser();

            var result = await usersController.ChangeProfilePicture(TestConstants.PictureUrl);

            Assert.Equal(TestConstants.PictureUrl, imageService.ImageUrl);
            //Assert.Equal(string.Empty, imageService.Destination);
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task GetProfilePictureShouldReturnCorrectFileStreamResult()
        {
            //Arenge          
            var usersController = new UsersController(null, new FakeFileSystemService()).WithTestUser();

            //Act
            var result = await usersController.GetProfilePicture();

            //Assert
            var fileStreamResult = Assert.IsType<FileStreamResult>(result);
            var memoryStream = Assert.IsType<MemoryStream>(fileStreamResult.FileStream);

            var memoryStreamData = memoryStream.ToArray();
            var memmoryStreamDataAsText = Encoding.UTF8.GetString(memoryStreamData);
            Assert.Equal(@$"Images\Users\{TestConstants.TestUserName}_optimized.jpg", memmoryStreamDataAsText);
            Assert.Equal(ControllerConstants.ImageContentType, fileStreamResult.ContentType);
        }
    }
}
