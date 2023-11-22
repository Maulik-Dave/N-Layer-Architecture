using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using DotNetCoreApi.Data.Context;
using System.Data;
using System.Linq.Expressions;

namespace DotNetCoreApi.Data.Infrastructure
{
    /* This class is use for Implement the Common Methods */
    public class RepositoryBase<T> where T : class
    {
        #region Properties
        private DBCon dataContext;
        private readonly DbSet<T> dbSet;

        protected IDBCon DBConCall
        {
            get;
            private set;
        }

        protected DBCon DbContext
        {
            get { return dataContext ?? (dataContext = DBConCall.Init()); }
        }
        #endregion
        /// <summary>
        /// Get full error
        /// </summary>
        /// <param name="exc">Exception</param>
        /// <returns>Error</returns>
        protected string GetFullErrorText(DbUpdateException exc)
        {
            var msg = string.Empty;
            foreach (var validationErrors in exc.Entries)

                msg += string.Format("Property: {0} Error: {1}", validationErrors.Entity.GetType().Name, validationErrors.State) + Environment.NewLine;
            return msg;
        }
        public RepositoryBase(IDBCon dbConCall)
        {
            DBConCall = dbConCall;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation

        public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            if (!string.IsNullOrEmpty(sql) && parameters != null)
            {
                var dynamicParameters = new DynamicParameters();

                if (parameters.GetType().FullName == "Microsoft.Data.SqlClient.SqlParameter[]")
                {
                    foreach (var param in parameters as SqlParameter[])
                    {
                        if (param.Value == DBNull.Value)
                            param.Value = null;

                        dynamicParameters.Add(param.ParameterName, param.Value);
                    }

                    var splitvalue = sql.Split(" ");
                    sql = splitvalue[0];

                    var dbConnection = new SqlConnection(DbContext.Database.GetConnectionString());
                    dbConnection.Open();
                    return dbConnection.Query<TElement>(sql, dynamicParameters, commandType: CommandType.StoredProcedure);
                }
                else
                {
                    int i = 0;
                    string newsql = sql;

                    foreach (var param in parameters)
                    {
                        dynamicParameters.Add("@param" + i, param);
                        string paramvalue = "{" + i + "}";
                        string replacedvalue = "@param" + i;
                        newsql = newsql.Replace(paramvalue, replacedvalue);
                        i++;
                    }

                    var dbConnection = new SqlConnection(DbContext.Database.GetConnectionString());
                    dbConnection.Open();
                    return dbConnection.Query<TElement>(newsql, dynamicParameters);
                }
            }
            return null;
        }

        public int ExecuteSqlCommand(string sql, params object[] parameters)
        {
            return DbContext.Database.ExecuteSqlRaw(sql, parameters);
        }

        public virtual void Add(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                dbSet.Add(entity);

            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Add(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                foreach (var entity in entities)
                    this.dbSet.Add(entity);


            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                dbSet.Attach(entity);
                dataContext.Entry(entity).State = EntityState.Modified;
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Update(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");
                foreach (var entity in entities)
                {
                    dbSet.Attach(entity);
                    dataContext.Entry(entity).State = EntityState.Modified;
                }


            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                dbSet.Remove(entity);
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(GetFullErrorText(dbEx), dbEx);
            }
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Delete(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                foreach (var entity in entities)
                    this.dbSet.Remove(entity);
            }
            catch (DbUpdateException dbEx)
            {

            }           
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        public virtual IEnumerable<T> GetWithInclude(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query;
        }

        public virtual IQueryable<T> GetWithIncludeQueryable(params Expression<Func<T
                                        , object>>[] includeProperties)
        {
            IQueryable<T> query = dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.dbSet;
            }
        }
        #endregion
    }
}