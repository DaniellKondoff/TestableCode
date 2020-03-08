using Blog.Services;
using System.IO;
using System.Text;

namespace Blog.Test.Fake
{
    public class FakeFileSystemService : IFileSystemService
    {
        public Stream OpenRead(string path)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(path));
        }

        public Stream OpenWrite(string path)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(path));
        }
    }
}
