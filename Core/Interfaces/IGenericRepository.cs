using Core.Specifications;

namespace Core.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();

    IEnumerable<T> FindWithSpecificationPattern(ISpecification<T>
        specification = null);

}
