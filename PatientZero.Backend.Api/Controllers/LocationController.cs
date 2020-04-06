using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PatientZero.Backend.Api.Models;

namespace PatientZero.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        // POST: api/Location
        [HttpPost]
        public void Post([FromBody] GpsValue[] positions)
        {
            Console.WriteLine(JsonConvert.SerializeObject(positions));
        }
    }
}
