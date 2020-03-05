using Blog.Services;
using System;

namespace Blog.Test.Fake
{
    public class FakeDateTimeService : IDateTimeService
    {
        public DateTime Now()
        {
            return new DateTime(2020, 1, 1);
        }
    }
}
