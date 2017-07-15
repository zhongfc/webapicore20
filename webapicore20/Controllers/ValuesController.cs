using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webapicore20.wwwroot
{
    [Route("api/[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values/GetSomeJson
        [HttpGet]
        [ActionName("GetSomeJson")]
        public IActionResult Get()
        {
            var result = @"{'name':'John','age':30,'cars':['Ford','BMW','Fiat']}";
            return Ok(result);
        }
    }
}
