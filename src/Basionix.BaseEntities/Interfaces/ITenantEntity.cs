namespace Basionix.BaseEntities.Interfaces
{
    using System;

    public interface ITenantEntity<TKey, TTenantType, TTenantKey, TDateTime> :
        IEntity<TKey>, IAmAuditable<TDateTime>
        where TKey : struct
        where TTenantType : ITenant<TTenantKey>
        where TTenantKey : struct
        where TDateTime : struct
    {
        TTenantKey TenantId { get; set; }
    }

    public interface ITenantEntityDateTimeOffset<TKey, TTenantType, TTenantKey> :
        ITenantEntity<TKey, TTenantType, TTenantKey, DateTimeOffset>
        where TKey : struct
        where TTenantType : ITenant<TTenantKey>
        where TTenantKey : struct
    {
    }

    public interface ITenantEntityDateTime<TKey, TTenantType, TTenantKey> :
        ITenantEntity<TKey, TTenantType, TTenantKey, DateTime>
        where TKey : struct
        where TTenantType : ITenant<TTenantKey>
        where TTenantKey : struct
    {
    }
}
