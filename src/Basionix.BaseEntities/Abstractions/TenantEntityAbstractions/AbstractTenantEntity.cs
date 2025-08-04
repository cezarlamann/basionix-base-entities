namespace Basionix.BaseEntities.Abstractions.TenantEntityAbstractions
{
    using System;

    using Basionix.BaseEntities.Abstractions;
    using Basionix.BaseEntities.Interfaces;

    public abstract class AbstractTenantEntity<TKey, TTenantType, TTenantKey> :
        AbstractEntity<TKey>,
        ITenantEntity<TKey, TTenantType, TTenantKey, DateTimeOffset>,
        IAmAuditable<DateTimeOffset>
        where TKey : struct
        where TTenantType : ITenant<TTenantKey>
        where TTenantKey : struct
    {
        public TTenantKey TenantId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public string? LastUpdatedBy { get; set; }
    }
}
