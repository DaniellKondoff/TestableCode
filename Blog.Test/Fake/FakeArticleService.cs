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
        public Task<int> Add(string title, string content, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ArticleListingServiceModel>> All(int page = 1, int pageSize = 12, bool publicOnly = true)
        {
            var articles = new List<ArticleListingServiceModel>
            {
               new ArticleListingServiceModel {Id =1 },
               new ArticleListingServiceModel {Id =2 },
               new ArticleListingServiceModel {Id =3 },
               new ArticleListingServiceModel {Id =4 },
               new ArticleListingServiceModel {Id =5 }
            };

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

        public Task<int> Total()
        {
            throw new NotImplementedException();
        }
    }
}
