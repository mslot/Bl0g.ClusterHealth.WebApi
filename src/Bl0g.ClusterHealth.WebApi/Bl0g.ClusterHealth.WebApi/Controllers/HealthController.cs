using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bl0g.ClusterHealth.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("Ping")]
        public async Task<ActionResult> Ping()
        {
            return await Task.FromResult(Ok("AKS online"));
        }
    }
}