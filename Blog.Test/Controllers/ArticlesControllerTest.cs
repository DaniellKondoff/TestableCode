using Blog.Controllers;
using Blog.Controllers.Models;
using Blog.Test.Fake;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test.Controllers
{
    public class ArticlesControllerTest
    {
        [Fact]
        public async Task AllShouldReturnViewWithCorrectModel()
        {
            //Arenge
            const int pageSize = 2;
            var articleService = new FakeArticleService();
            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(new[] 
                {
                    new KeyValuePair<string, string>("Articles:PageSize",pageSize.ToString())
                })
                .Build();

            var articlesController = new ArticlesController(articleService, null, configuration);

            //Act
            var result = await articlesController.All();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<ArticleListingViewModel>(viewResult.Model);
            Assert.Equal(1, model.Page);
            Assert.Equal(await articleService.Total(), model.Total);
            Assert.Equal(pageSize, model.Articles.Count());
        }
    }
}
