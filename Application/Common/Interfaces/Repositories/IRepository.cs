using System.Linq.Expressions;


namespace Application.Common.Interfaces.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    Task<T> Create(T entity);

    Task<T> Update(T entity);

    Task<T> Get(Expression<Func<T, bool>> expression);

    Task<T> GetAll();
    
    Task<T> GetAllByExpression(Expression<Func<T, bool>> expression);
}
