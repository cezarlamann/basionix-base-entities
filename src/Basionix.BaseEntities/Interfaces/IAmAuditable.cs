namespace Basionix.BaseEntities.Interfaces
{
    using System;

    public interface IAmAuditable<T> :
        IHaveAuditableCreation<T>,
        IHaveAuditableUpdate<T>
        where T : struct
    {
    }

    public interface IAmAuditableDateTimeOffset : IAmAuditable<DateTimeOffset>
    {
    }

    public interface IAmAuditableDateTime : IAmAuditable<DateTime>
    {
    }
}
