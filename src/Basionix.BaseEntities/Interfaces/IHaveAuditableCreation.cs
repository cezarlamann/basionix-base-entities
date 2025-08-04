namespace Basionix.BaseEntities.Interfaces
{
    public interface IHaveAuditableCreation<T> where T : struct
    {
        T CreatedAt { get; set; }
        string CreatedBy { get; set; }
    }
}
