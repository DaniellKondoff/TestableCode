using Blog.Services;

namespace Blog.Test.Fake
{
    public class FakeRandomService : IRandomService
    {
        private readonly int randomNumber;

        public FakeRandomService(int randomNumber)
        {
            this.randomNumber = randomNumber;
        }
        public int Next(int min, int max)
        {
            return this.randomNumber;
        }
    }
}
