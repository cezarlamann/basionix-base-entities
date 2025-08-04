namespace Basionix.BaseEntities.Abstractions
{
    using Basionix.BaseEntities.Interfaces;

    public abstract class AbstractEntity<TKey> : IEntity<TKey> where TKey : struct
    {
        public TKey Id { get; set; }
    }
}
