using System.IO;

namespace Blog.Services
{
    public class FileSystemService : IFileSystemService
    {
        public Stream OpenRead(string path)
        {
            return File.OpenRead(path);
        }
    }
}
