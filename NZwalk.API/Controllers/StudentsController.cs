using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZwalk.API.Controllers
{
    // https://localhost:7071/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] stdentNames = new string[] { "chai", "cai", "wang", "liu", "zhang" };
            return Ok(stdentNames);
        }
    }
}