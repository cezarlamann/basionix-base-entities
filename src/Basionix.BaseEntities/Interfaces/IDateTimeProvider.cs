namespace Basionix.BaseEntities
{
    using System;

    public interface IDateTimeProvider
    {
        DateTimeOffset UtcNowOffset { get; }
        DateTime UtcNow { get; }
    }
}
