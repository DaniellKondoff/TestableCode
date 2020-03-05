using System.IO;

namespace Blog.Services
{
    public interface IFileSystemService
    {
        Stream OpenRead(string path);
    }
}
