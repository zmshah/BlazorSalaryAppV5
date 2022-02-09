using BlazorSalaryAppV5.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSalaryAppV5.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryRepository salaryRepository;
        public SalaryController(ISalaryRepository salaryRepository)
        {
            this.salaryRepository = salaryRepository;
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<SalaryData>>> Search(Nullable<int> ID, string Department, string College, string Division, string JobTitle)
        //public async Task<ActionResult<IEnumerable<SalaryData>>> Search(string Department, string College, string Division, string JobTitle)
        {
            try
            {
                var result = await salaryRepository.Search(ID, Department, College, Division, JobTitle);
                //var result = await salaryRepository.Search(Department, College, Division, JobTitle);

                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }


        [HttpGet]
        public async Task<ActionResult> GetSalaries()
        {
            try
            {
                return Ok(await salaryRepository.GetSalaries());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<SalaryData>> GetSalary(int id)
        {
            try
            {
                var result = await salaryRepository.GetSalary(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<SalaryData>> CreateSalary(SalaryData salaryData)
        {
            try
            {
                if (salaryData == null)
                    return BadRequest();

                var createdSalary = await salaryRepository.AddSalary(salaryData);

                return CreatedAtAction(nameof(GetSalary),
                    new { id = createdSalary.ID }, createdSalary);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new salary record");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<SalaryData>> UpdateSalary(int id, SalaryData salaryData)
        {
            try
            {
                if (id != salaryData.ID)
                    return BadRequest("Salary ID mismatch");


                var salaryToUpdate = await salaryRepository.GetSalary(id);

                if (salaryToUpdate == null)
                {
                    return NotFound($"Salary with Id = {id} not found");
                }

                return await salaryRepository.UpdateSalary(salaryData);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new salary record");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteSalary(int id)
        {
            try
            {
                var salaryToDelete = await salaryRepository.GetSalary(id);

                if (salaryToDelete == null)
                {
                    return NotFound($"Salary with Id = {id} not found");
                }

                await salaryRepository.DeleteSalary(id);

                return Ok($"Salary with Id = {id} deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Salary record");
            }
        }
    }
}
