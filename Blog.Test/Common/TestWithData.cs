using Blog.Data.Models;
using Blog.Test.Fake;
using System.Threading.Tasks;

namespace Blog.Test.Common
{
    public abstract class TestWithData
    {
        protected async Task InitDatabase(string databaseName)
        {
            this.Database = new FakeBlogDbContext(databaseName);

            await this.AddFakeArticles(this.Database);
        }

        protected FakeBlogDbContext Database { get; private set; }
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
    }
}
