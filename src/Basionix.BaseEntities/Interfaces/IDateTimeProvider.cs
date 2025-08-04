namespace Basionix.BaseEntities.Interfaces
{
    using System;

    public interface IDateTimeProvider
    {
        DateTimeOffset UtcNowOffset { get; }
        DateTime UtcNow { get; }
    }
}
