namespace Basionix.BaseEntities
{
    public interface ITenantEntity<TKey, TTenantType, TTenantKey> : IEntity<TKey>, IAmAuditable
        where TKey :struct
        where TTenantType : ITenant<TTenantKey>
        where TTenantKey : struct
    {
        TTenantKey TenantId { get; set; }
    }
}
