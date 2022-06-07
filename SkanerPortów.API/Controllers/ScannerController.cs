using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SkanerPortów.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScannerController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostScan(Dictionary<int, bool> portScanResult)
        {
            return Ok();
        }
    }
}
