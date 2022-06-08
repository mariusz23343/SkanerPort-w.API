using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SkanerPortów.API.Dtos;
using SkanerPortów.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkanerPortów.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScannerController : ControllerBase
    {
        private readonly DataContext _context;

        public ScannerController(DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> PostScan(PortListDto portScanResult)
        {
            foreach (var pair in portScanResult.portDict)
            {
                var scanEntity = new ScanEntity
                {
                    PortNumber = pair.Key,
                    IsOpen = pair.Value,
                    Ipv4 = portScanResult.IPv4,
                    ScanDate = portScanResult.ScanDate
                };
                _context.ScanEntities.Add(scanEntity);
            }

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
