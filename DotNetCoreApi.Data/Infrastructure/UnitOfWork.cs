using DotNetCoreApi.Data.Context;

namespace DotNetCoreApi.Data.Infrastructure
{
    /* This class is use for Commit the Resources */
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBCon dbFactory;
        private DBCon dbContext;

        public UnitOfWork(IDBCon dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public DBCon DBContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DBContext.Commit();
        }
    }
}
