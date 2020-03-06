using System;

namespace Blog.Services
{
    public class RandomService : IRandomService
    {
        private static readonly Random random = new Random();
        public int Next(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
