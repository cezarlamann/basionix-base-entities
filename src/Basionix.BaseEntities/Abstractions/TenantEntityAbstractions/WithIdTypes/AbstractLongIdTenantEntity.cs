namespace Basionix.BaseEntities.Abstractions.TenantEntityAbstractions.WithIdTypes
{
    public abstract class AbstractLongIdTenantEntity<T> :
        AbstractTenantEntity<T, AbstractLongIdTenant, long>
        where T : struct
    {
    }
}
