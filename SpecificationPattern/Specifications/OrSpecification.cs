namespace SpecificationPattern.Specifications
{
    public class OrSpecification<T> : Specification<T> where T : class
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            _left  = left;
            _right = right;            
        }

        public override bool IsSatisfiedBy(T entity)
            => _left.IsSatisfiedBy(entity)
            || _right.IsSatisfiedBy(entity);
    }
}

