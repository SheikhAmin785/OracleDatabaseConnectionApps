using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OracleDatabaseConnectionApps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly DataAccess _dataAccess;

        public DataController(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpGet]
        public IActionResult GetData()
        {
            var query = "select * from policy";
            var result = _dataAccess.ExecuteQuery(query);
            return Ok(result);
        }

        // Add other action methods as needed
    }
}