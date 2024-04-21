namespace Basionix.BaseEntities
{
    using Basionix.BaseEntities.TenantEntityAbstractions;

    public abstract class AbstractLongIdTenantEntity<T> : AbstractTenantEntity<T, AbstractLongIdTenant, long> where T : struct
    {
    }
}
