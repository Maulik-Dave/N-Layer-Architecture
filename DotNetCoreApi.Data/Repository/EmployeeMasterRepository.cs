using DotNetCoreApi.Data.Infrastructure;
using DotNetCoreApi.Model;

namespace DotNetCoreApi.Data.Repository
{
    public class EmployeeMasterRepository : RepositoryBase<EmployeeMasterModel>, IEmployeeMasterRepository
    {
        public EmployeeMasterRepository(IDBCon dbConCall) : base(dbConCall)
        {
        }
    }
}