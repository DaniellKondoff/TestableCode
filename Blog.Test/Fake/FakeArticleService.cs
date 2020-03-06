using Blog.Data.Models;
using Blog.Services;
using Blog.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Test.Fake
{
    public class FakeArticleService : IArticleService
    {
        private List<Article> articleData = new List<Article>
        {
            new Article {Id = 1},
            new Article {Id = 2},
            new Article {Id = 3},
            new Article {Id = 4},
            new Article {Id = 5}
        };

        public Task<int> Add(string title, string content, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ArticleListingServiceModel>> All(int page = 1, int pageSize = 12, bool publicOnly = true)
        {
            var articles = this.articleData
                .Select(a => new ArticleListingServiceModel
                {
                    Id = a.Id
                });

            return await Task.FromResult(articles.Take(pageSize));
        }

        public Task<IEnumerable<TModel>> All<TModel>(int page = 1, int pageSize = 12, bool publicOnly = true) where TModel : class
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> AllIds()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArticleForUserListingServiceModel>> ByUser(string userId)
        {
            throw new NotImplementedException();
        }

        public Task ChangeVisibility(int id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleDetailsServiceModel> Details(int id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int id, string title, string content)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsByUser(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Total()
        {
            return await Task.FromResult(this.articleData.Count);
        }
    }
}
