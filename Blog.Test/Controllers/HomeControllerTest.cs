using Blog.Controllers;
using Blog.Controllers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using Xunit;

namespace Blog.Test.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void AboutShouldReturnViewResult()
        {
            var homeController = new HomeController();

            var result = homeController.About();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PrivacyShouldReturnViewResultWIthCorrectUserName()
        {
            const string UserName = "TestUser";
            var homeController = new HomeController();
            homeController.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, UserName)
                    }))
                }
            };

            var result = homeController.Privacy();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<PrivacyViewModel>(viewResult.Model);
            Assert.Equal(UserName, model.Username);
        }
    }
}
