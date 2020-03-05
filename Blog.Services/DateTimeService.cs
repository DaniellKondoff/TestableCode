using System;

namespace Blog.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime Now()
        {
            return DateTime.UtcNow;
        }
    }
}
