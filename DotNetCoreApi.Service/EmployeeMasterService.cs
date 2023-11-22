using DotNetCoreApi.Data.Infrastructure;
using DotNetCoreApi.Data.Repository;
using DotNetCoreApi.Helper.Constants;
using DotNetCoreApi.Model;

namespace DotNetCoreApi.Service
{
    public class EmployeeMasterService : IEmployeeMasterService
    {
        private readonly IEmployeeMasterRepository employeemasaterRepository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeMasterService(IEmployeeMasterRepository employeemasaterRepository, IUnitOfWork unitOfWork)
        {
            this.employeemasaterRepository = employeemasaterRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateEmployeeMaster(EmployeeMasterModel employeemaster)
        {
            if (employeemaster != null)
            {
                employeemaster.EmployeeMasterDeleted = Constants.NotDeleted;
                employeemasaterRepository.Add(employeemaster);
            }
        }

        public void SaveEmployeeMaster()
        {
            unitOfWork.Commit();
        }

        public EmployeeMasterModel GetEmployeeMaster(int id)
        {
            var employeemaster = employeemasaterRepository.GetById(id);
            return employeemaster;
        }

        public void UpdateEmployeeMaster(EmployeeMasterModel employeemaster)
        {
            employeemasaterRepository.Update(employeemaster);
        }

        public void DeleteEmployeeMaster(EmployeeMasterModel employeemaster)
        {
            employeemasaterRepository.Delete(employeemaster);
        }

        public IEnumerable<EmployeeMasterModel> GetEmployeeMaster()
        {
            return employeemasaterRepository.GetAll();
        }
    }
}