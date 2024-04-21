namespace Basionix.BaseEntities
{
    using System;

    public interface IAmAuditable
    {
        DateTimeOffset CreatedAt { get; set; }
        DateTimeOffset? UpdatedAt { get; set; }
        string CreatedBy { get; set; }
        string? LastUpdatedBy { get; set; }
    }
}
