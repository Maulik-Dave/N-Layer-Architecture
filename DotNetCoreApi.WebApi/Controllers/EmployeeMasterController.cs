using AutoMapper;
using DotNetCoreApi.Model;
using DotNetCoreApi.Service;
using DotNetCoreApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApi.WebApi.Controllers
{
    [Route("WebAPI/EmployeeMaster")]
    public class EmployeeMasterController : ControllerBase
    {
        private readonly IEmployeeMasterService employeemasterService;
        private readonly IMapper _mapper;

        public EmployeeMasterController(IEmployeeMasterService employeemasterService, IMapper mapper)
        {
            this.employeemasterService = employeemasterService;
            _mapper = mapper;
        }

        ///* This Method Use For Get all the Data OF EmployeeMaster */

        [HttpGet]
        [Route("GetAllEmployeeMaster")]
        public IActionResult GetAll()
        {
            IEnumerable<EmployeeMasterViewModel> viewModelEmployeeMaster;
            IEnumerable<EmployeeMasterModel> employeemaster;

            employeemaster = employeemasterService.GetEmployeeMaster().ToList();

            viewModelEmployeeMaster = _mapper.Map<IEnumerable<EmployeeMasterModel>, IEnumerable<EmployeeMasterViewModel>>(employeemaster);

            if (viewModelEmployeeMaster != null)
            {
                if (viewModelEmployeeMaster.Any())
                    return Ok(viewModelEmployeeMaster);
            }
            return NotFound();
        }

        /* This Method Use For Get Data By ID of EmployeeMaster */
        // GET api/values/5
        [HttpGet]
        [Route("GetEmployeeMasterById/{id}")]
        public IActionResult GetById(int id)
        {
            EmployeeMasterViewModel viewModelemployeemaster;
            EmployeeMasterModel employeemaster = employeemasterService.GetEmployeeMaster(id);

            viewModelemployeemaster = _mapper.Map<EmployeeMasterModel, EmployeeMasterViewModel>(employeemaster);
            if (viewModelemployeemaster != null)
                return Ok(viewModelemployeemaster);

            return Content("No Employee Master found for this id: " + id);
        }

        /* This Method Use For Create EmployeeMaster */
        // POST api/values

        [HttpPost]
        [Route("CreateEmployeeMaster")]
        public IActionResult Add([FromBody] EmployeeMasterFormViewModel employeemaster)
        {
            if (employeemaster != null)
            {
                var employeemastermapper = _mapper.Map<EmployeeMasterFormViewModel, EmployeeMasterModel>(employeemaster);
                employeemasterService.CreateEmployeeMaster(employeemastermapper);
                employeemasterService.SaveEmployeeMaster();

                employeemaster.EmployeeMasterID = employeemastermapper.EmployeeMasterID;

                return Created("New employee created", employeemaster);
            }

            return Content("New employee is not Created");
        }

        // PUT api/values/5
        [HttpPut]
        [Route("UpdateEmployeeMaster/{id}")]
        public bool Put(int id, [FromBody] EmployeeMasterFormViewModel employeemaster)
        {
            if (employeemaster != null)
            {
                var employeemastermapper = _mapper.Map<EmployeeMasterFormViewModel, EmployeeMasterModel>(employeemaster);
                employeemastermapper.EmployeeMasterID = id;
                employeemasterService.UpdateEmployeeMaster(employeemastermapper);
                employeemasterService.SaveEmployeeMaster();

                return true;
            }
            return false;
        }

        /* This Method Use For Delete Data  of EmployeeMaster */
        // DELETE api/values/5
        [HttpDelete]
        [Route("DeleteEmployeeMaster/{id}")]
        public bool Delete(int id)
        {
            if (id != 0)
            {
                var employeemaster = new EmployeeMasterFormViewModel();
                var employeemastermapper = _mapper.Map<EmployeeMasterFormViewModel, EmployeeMasterModel>(employeemaster);
                employeemastermapper.EmployeeMasterID = id;
                employeemasterService.DeleteEmployeeMaster(employeemastermapper);

                employeemasterService.SaveEmployeeMaster();
                return true;
            }
            return false;
        }
    }
}