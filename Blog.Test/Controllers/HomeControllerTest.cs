using Blog.Controllers;
using Blog.Controllers.Models;
using Blog.Services.Models;
using Blog.Test.Extensions;
using Blog.Test.Fake;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void AboutShouldReturnViewResult()
        {
            var homeController = new HomeController(null);

            var result = homeController.About();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PrivacyShouldReturnViewResultWIthCorrectUserName()
        {
            var homeController = new HomeController(null).WithTestUser();
            
            var result = homeController.Privacy();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<PrivacyViewModel>(viewResult.Model);
            Assert.Equal(TestConstants.TestUserName, model.Username);
        }

        [Fact]
        public async Task IndexShouldReturnViewResultWithCorrectArticle()
        {
            var homeController = new HomeController(new FakeArticleService());

            var result = await homeController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<ArticleListingServiceModel>>(viewResult.Model);
            Assert.Equal(3, model.Count());
        }
    }
}
