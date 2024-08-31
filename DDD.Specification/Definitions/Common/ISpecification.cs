namespace DDD.Specifications.Definitions.Common
{
    public interface ISpecification<T>
    {
        public bool IsSatisfiedBy(T entity);
    }
}
