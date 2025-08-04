namespace Basionix.BaseEntities.Abstractions.TenantEntityAbstractions.WithIdTypes
{
    using System;

    public class AbstractGuidIdTenantEntity<T> :
        AbstractTenantEntity<T, AbstractGuidIdTenant, Guid>
        where T : struct
    {
    }
}
