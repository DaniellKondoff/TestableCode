using Blog.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Blog.Test.Fake
{
    public class FakeBlogDbContext
    {
        
        public FakeBlogDbContext(string name)
        {
            var options = new DbContextOptionsBuilder<BlogDbContext>()
                .UseInMemoryDatabase(name)
                .Options;

           this.Data = new BlogDbContext(options);
        }

        public BlogDbContext Data { get; }

        public async Task Add(params object[] data)
        {
            this.Data.AddRange(data);
            await this.Data.SaveChangesAsync();
        }
    }
}
