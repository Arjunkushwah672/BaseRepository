using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BaseRepository.Models;
using BaseRepository.Data;
using BaseRepository.Repository;

namespace BaseRepository.Controllers
{
    [ApiController]
    [Route("api/Registration")]
    public class MstRegistrationController : Controller
    {
        private readonly IEmployeeRegistration _employeeRegistration;
        public MstRegistrationController(IEmployeeRegistration employeeRegistration)
        {
            _employeeRegistration = employeeRegistration;
        }

        [HttpGet(Name = "Index")]
        public async Task<IActionResult> Index()
        {
            var mstUserTypes = await _employeeRegistration.GetAllRegistrations();
            return Ok(mstUserTypes);
        }

        [HttpGet("GetUserType")]
        public async Task<IActionResult> GetUserType()
        {
            var userTypes = await _employeeRegistration.GetAllRegistrations();
            return Ok(userTypes);
        }


        [HttpPost(Name = "Create")]
        public async Task<IActionResult> Create([FromBody] MstRegistration model)
        {
            if (model == null || string.IsNullOrEmpty(model.Name))
            {
                return BadRequest("Name is required.");
            }

            await _employeeRegistration.AddRegistration(model);


            return Ok("Data Inserted Success");
        }

        [HttpPut("{registrationId}")]
        public async Task<IActionResult> Edit(int registrationId, [FromBody] MstRegistration mstRegistration)
        {
            var entity = await _employeeRegistration.GetRegistrationById(registrationId);
            if (entity == null)
            {
                return NotFound("Data not found.");
            }
            entity.Name = mstRegistration.Name;
            entity.Email = mstRegistration.Email;
            entity.Phone = mstRegistration.Phone;
            entity.Address = mstRegistration.Address;
            entity.Message = mstRegistration.Message;
            await _employeeRegistration.UpdateRegistration(entity);

            return Ok("Data Updated Success");
        }

        [HttpDelete("{registrationId}")]
        public async Task<IActionResult> Delete(int registrationId)
        {

            await _employeeRegistration.DeleteRegistration(registrationId);

            return Ok("Data Deleted Success");
        }


    }
}
