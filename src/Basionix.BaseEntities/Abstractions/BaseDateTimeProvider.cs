namespace Basionix.BaseEntities
{
    using System;

    public class BaseDateTimeProvider : IDateTimeProvider
    {
        public virtual DateTimeOffset UtcNowOffset => DateTimeOffset.UtcNow;

        public virtual DateTime UtcNow => DateTime.UtcNow;
    }
}
