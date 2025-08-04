namespace Basionix.BaseEntities.Abstractions.TenantEntityAbstractions.WithIdTypes
{
    public abstract class AbstractIntIdTenantEntity<T> :
        AbstractTenantEntity<T, AbstractIntIdTenant, int>
        where T : struct
    {
    }
}
