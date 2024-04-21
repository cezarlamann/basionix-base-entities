namespace Basionix.BaseEntities
{
    public interface ITenant<TKey> : IEntity<TKey> where TKey : struct
    {
        string TenantName { get; set; }
    }
}
