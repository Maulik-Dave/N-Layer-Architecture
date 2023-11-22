using DotNetCoreApi.Model;

namespace DotNetCoreApi.Service
{
    public interface IEmployeeMasterService
    {
        void CreateEmployeeMaster(EmployeeMasterModel employeemaster);
        void SaveEmployeeMaster();
        IEnumerable<EmployeeMasterModel> GetEmployeeMaster();
        EmployeeMasterModel GetEmployeeMaster(int id);
        void UpdateEmployeeMaster(EmployeeMasterModel employeemaster);
        void DeleteEmployeeMaster(EmployeeMasterModel employeemaster);
    }
}