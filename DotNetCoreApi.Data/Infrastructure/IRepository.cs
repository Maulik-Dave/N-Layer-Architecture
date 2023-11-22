using System.Linq.Expressions;

namespace DotNetCoreApi.Data.Infrastructure
{
    /* This class is use for Interface of the Repository */
    public interface IRepository<T> where T : class
    {

        // Marks an entity as new
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        // Marks an entity as modified
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        // Marks an entity to be removed
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        void Delete(IEnumerable<T> entities);
        // Get an entity by int id
        T GetById(int id);
        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);
        // Gets all entities of type T
        IEnumerable<T> GetAll();
        IQueryable<T> Table { get; }
        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        IEnumerable<T> GetWithInclude(params Expression<Func<T
                                         , object>>[] includeProperties);
        IQueryable<T> GetWithIncludeQueryable(params Expression<Func<T
                                        , object>>[] includeProperties);
        int ExecuteSqlCommand(string sql, params object[] parameters);
    }
}
