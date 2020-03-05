using AutoMapper;
using Blog.Data.Models;
using Blog.Services;
using Blog.Services.Infrastructure;
using Blog.Test.Fake;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Blog.Test.Services
{
    public class ArticleServiceTest
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

        private async Task AddFakeArticles(FakeBlogDbContext fakeDb)
        {
            await fakeDb.Add(new Article
            {
                Id = 1,
                UserId = "1",
                Title = "Test Article"
            },
            new Article
            {
                Id = 2,
                UserId = "2",
                Title = "Test Article 2",
                IsPublic = true
            });
        }

        private async Task<ArticleService> GetArticleService(string databaseName)
        {
            var db = new FakeBlogDbContext(databaseName);

            await AddFakeArticles(db);

            var mapper = new Mapper(new MapperConfiguration(config =>
            {
                config.AddProfile<ServiceMappingProfile>();
            }));

            return new ArticleService(db.Data, mapper);
        }

    }
}
