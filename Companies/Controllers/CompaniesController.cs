using Companies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace Companies.Controllers
{
    [Route("api/[controller]")] // => /api/Companies
    [ApiController]
    public class CompaniesController : ControllerBase
    {

        // /api/Companies
        [HttpGet]
        public IActionResult GetAllCompanies()
        {  
            // LOGIC GAMAY
            return Ok("ALL COMPANIES IMAGINA LNG.");
        }

        /// <summary>
        /// Gets a company with a specified Id
        /// 
        /// 
        /// Example:
        /// 
        /// `GET /api/companies/1`
        /// </summary>
        /// <param name="id">Id of the company</param>
        /// <returns>Company with the Id</returns>
        [HttpGet("{id}")]
        public IActionResult GetCompany(int id)
        {
            // companyService.GetById(id);
            // null ? ni exist? return (404)
            // 
            if (id == 4) // FOR DEMO
            {
                return NotFound();
            }

            return Ok("Company with Id : " + id);
        }

        [HttpPost] // POST api/Companies
        public IActionResult CreateCompany(Company company)
        {
            // LOGIC
            return Ok("Create company: " + company.Name);
        }

        [HttpPut] // PUT api/Companies
        public IActionResult UpdateCompany(Company company)
        {
            // LOGIC
            return Ok("Updating company: " + company.Name);
        }

        [HttpDelete("{id}")] // DELETE api/Companies/1
        public IActionResult DeleteCompany(int id)
        {
            // LOGIC
            return NoContent();
        }
    }
}
