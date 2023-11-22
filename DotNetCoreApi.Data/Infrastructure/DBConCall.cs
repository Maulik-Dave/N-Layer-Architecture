namespace DotNetCoreApi.Data.Infrastructure
{
    /* This class is use for DBCon Call */
    public class DBConCall:Disposable,IDBCon
    {
        private readonly Context.DBCon _dbContext;

        private Context.DBCon _dataContext;
        //Context.DBCon dbContext;
        public DBConCall(Context.DBCon dbContext)
        {
            _dbContext = dbContext;

        }
        public Context.DBCon Init()
        {
            return _dataContext ??= _dbContext;
        }

        protected override void DisposeCore()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}
