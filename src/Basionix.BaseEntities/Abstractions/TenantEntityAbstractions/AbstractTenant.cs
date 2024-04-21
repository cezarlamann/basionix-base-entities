namespace Basionix.BaseEntities.TenantEntityAbstractions
{
    using System;

    public abstract class AbstractTenant<TKey> : AbstractEntity<TKey>, ITenant<TKey>, IAmAuditable, IAmSoftDeletable
        where TKey : struct
    {
        public string TenantName { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? UpdatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public string? LastUpdatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTimeOffset? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
    }
}
