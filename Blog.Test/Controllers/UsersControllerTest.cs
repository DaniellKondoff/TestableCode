using Blog.Controllers;
using Blog.Test.Extensions;
using Blog.Test.Fake;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test.Controllers
{
    public class UsersControllerTest
    {
        [Fact]
        public async Task NullPictureUrlShouldReturnBadRequest()
        {
            var usersController = new UsersController(null);

            var result = await usersController.ChangeProfilePicture(null);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task ChangeProfilePictureWithNonNullPicUrlShouldReturnOk()
        {
            var imageService = new FakeImageService();
            var usersController = new UsersController(imageService).WithTestUser();

            var result = await usersController.ChangeProfilePicture(TestConstants.PictureUrl);

            Assert.Equal(TestConstants.PictureUrl, imageService.ImageUrl);
            //Assert.Equal(string.Empty, imageService.Destination);
            Assert.IsType<OkResult>(result);
        }
    }
}
