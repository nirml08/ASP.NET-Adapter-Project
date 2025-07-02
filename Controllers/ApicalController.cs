using adapter.Services;
using Microsoft.AspNetCore.Mvc;
using adapter.Model.apicaldata;

namespace adapter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApicalController : ControllerBase
    {
        private readonly Apical _apical;

        public ApicalController(Apical apical)
        {
            _apical = apical;
        }

        // GET: api/apical/applications
        /*[HttpGet("applications")]
        public async Task<ActionResult<IEnumerable<ApplicationInfo>>> GetAllApplications()
        {
            var applications = await _apical.GetAllApplicationsAsync();
            return (applications == null || !applications.Any()) ? NotFound() : Ok(applications);
        }*/
        [HttpGet("applications")]
        public async Task<IActionResult> GetAllApplications()
        {
            try
            {
                var applications = await _apical.GetAllApplicationsAsync();
                return Ok(); 
            }
            catch (Exception ex)
            {
                // Optionally log the error
                Console.WriteLine($"Error in GetAllApplications: {ex.Message}");

                // Return 500 Internal Server Error
                return StatusCode(500, "An error occurred while retrieving applications.");
            }
        }


        // OPTIONAL: Add endpoint to fetch application by ID (uncomment if GetApplicationByIdAsync is enabled)
        /*
        [HttpGet("applications/{id}")]
        public async Task<ActionResult<Application>> GetApplicationById(string id)
        {
            var app = await _apical.GetApplicationByIdAsync(id);
            return (app == null) ? NotFound() : Ok(app);
        }
        */
    }
}
