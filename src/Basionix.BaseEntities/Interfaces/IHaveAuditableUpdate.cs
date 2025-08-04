namespace Basionix.BaseEntities.Interfaces
{
    public interface IHaveAuditableUpdate<T> where T : struct
    {
        T? UpdatedAt { get; set; }
        string? LastUpdatedBy { get; set; }
    }
}
