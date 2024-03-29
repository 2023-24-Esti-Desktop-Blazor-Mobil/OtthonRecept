using Shared.Responses;
using System.Linq.Expressions;

namespace BackEnd.Repos
{
    public interface IRepositoryBase<T>
    {
            
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<ControllerResponse> UpdateAsync(T entity);
        Task<ControllerResponse> DeleteAsync(Guid id);
        Task<ControllerResponse> CreateAsync(T entity);
    }
}

