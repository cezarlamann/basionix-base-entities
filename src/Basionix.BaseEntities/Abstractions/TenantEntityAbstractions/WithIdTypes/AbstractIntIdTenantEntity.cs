namespace Basionix.BaseEntities
{
    using Basionix.BaseEntities.TenantEntityAbstractions;

    public abstract class AbstractIntIdTenantEntity<T> : AbstractTenantEntity<T, AbstractIntIdTenant, int> where T : struct
    {
    }
}
