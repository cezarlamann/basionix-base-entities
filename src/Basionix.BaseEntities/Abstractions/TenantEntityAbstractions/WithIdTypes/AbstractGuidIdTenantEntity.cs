namespace Basionix.BaseEntities
{
    using System;
    using Basionix.BaseEntities.TenantEntityAbstractions;

    public class AbstractGuidIdTenantEntity<T> : AbstractTenantEntity<T, AbstractGuidIdTenant, Guid> where T : struct
    {
    }
}
