using System.IO;

namespace Blog.Services
{
    public class FileSystemService : IFileSystemService
    {
        public Stream OpenRead(string path)
        {
            return File.OpenRead(path);
        }

        public Stream OpenWrite(string path)
        {
            return File.OpenWrite(path);
        }
    }
}
