using adapter.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using adapter.Model.classmodel;


namespace adapter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class socket : ControllerBase
    {
        private readonly socketservice _socketserv;
        public socket(socketservice socketserv)
        {
            _socketserv = socketserv;
        }

        [HttpGet("callsocket")]
        public async Task<ActionResult<IEnumerable<StudentClass>>> callsocket([FromQuery] string rollno)
        {
            //place the controller call
            var result = await _socketserv.FetchSelectedStudent(rollno);
            return (result==null|| !result.Any()) ?NotFound():Ok(result);

        }

    }
}
