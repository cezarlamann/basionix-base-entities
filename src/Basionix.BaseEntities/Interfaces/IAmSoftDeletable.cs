namespace Basionix.BaseEntities.Interfaces
{
    using System;

    public interface IAmSoftDeletable<T> where T : struct
    {
        bool IsDeleted { get; set; }
        T? DeletedAt { get; set; }
        string? DeletedBy { get; set; }
    }

    public interface IAmSoftDeletableDateTimeOffset : IAmSoftDeletable<DateTimeOffset>
    {
    }

    public interface IAmSoftDeletableDateTime : IAmSoftDeletable<DateTime>
    {
    }
}
