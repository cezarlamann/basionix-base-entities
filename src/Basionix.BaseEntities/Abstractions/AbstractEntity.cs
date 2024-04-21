namespace Basionix.BaseEntities
{
    public abstract class AbstractEntity<TKey> : IEntity<TKey> where TKey : struct
    {
        public TKey Id { get; set; }
    }
}
