namespace Basionix.BaseEntities.Abstractions
{
    using System;

    using Basionix.BaseEntities.Interfaces;

    public class BaseDateTimeProvider : IDateTimeProvider
    {
        public virtual DateTimeOffset UtcNowOffset => DateTimeOffset.UtcNow;

        public virtual DateTime UtcNow => DateTime.UtcNow;
    }
}
