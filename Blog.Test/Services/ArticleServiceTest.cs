using AutoMapper;
using Blog.Services;
using Blog.Services.Infrastructure;
using Blog.Test.Common;
using Blog.Test.Fake;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test.Services
{
    public class ArticleServiceTest : TestWithData
    {

        [Fact]
        public async Task IsByUserShouldReturnTrueWhenArticleByTheSpecificUserExists()
        {
            //Arenge
            const string databaseName = "ArticlesIsByUser";

            var acticleService = await this.GetArticleService(databaseName);

            //Act
            var exist = await acticleService.IsByUser(1, "1");

            //Assert
            Assert.True(exist);
        }

        [Fact]
        public async Task IsByUserShouldReturnFalseWhenArticleByTheSpecificUserDoesNotExists()
        {
            //Arenge
            const string databaseName = "ArticlesIsByUserDoesNotExists";

            var acticleService = await this.GetArticleService(databaseName);

            //Act
            var exist = await acticleService.IsByUser(3, "1");

            //Assert
            Assert.False(exist);
        }

        [Fact]
        public async Task AllShouldReturnCorrectArticlesWithDefaultParameters()
        {
            //Arange
            var articleService = await this.GetArticleService("AllArticlesWithdefaultparameters");

            //Act
            var articles = await articleService.All();

            //Assert
            var article = Assert.Single(articles);
            Assert.NotNull(article);
            Assert.Equal(2, article.Id);
        }

        [Fact]
        public async Task ChangeVisibilityShouldSetCorrectPublishedOnDate()
        {
            //Arenge
            const int articleId = 1;
            var articleService = await this.GetArticleService("ChangeVisibility");

            //Act
            await articleService.ChangeVisibility(articleId);

            //Assert
            var article  = this.Database.Data.Articles.Find(articleId);

            Assert.NotNull(article);
            Assert.True(article.IsPublic);
            Assert.Equal(new DateTime(2020, 1, 1), article.PublishedOn);
        }

       

        private async Task<ArticleService> GetArticleService(string databaseName)
        {
            await this.InitDatabase(databaseName);

            var mapper = new Mapper(new MapperConfiguration(config =>
            {
                config.AddProfile<ServiceMappingProfile>();
            }));


            return new ArticleService(this.Database.Data, mapper, new FakeDateTimeService());
        }

    }
}
