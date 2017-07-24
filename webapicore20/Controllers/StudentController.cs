using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapicore20.Data;
using Microsoft.EntityFrameworkCore;

namespace webapicore20.wwwroot
{
    [Route("api/[controller]/[action]")]
    public class StudentsController : ControllerBase
    {

        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }

        // GET api/values/GetSomeJson
        [HttpGet]
        [ActionName("GetSomeJson")]
        public IActionResult Get()
        {
            var result = @"{'name':'John','age':30,'cars':['Ford','BMW','Fiat']}";
            return Ok(result);
        }

        //GET api/Students/GetStudents
        [HttpGet]
        [ActionName("GetStudents")]
        public async Task<IActionResult> Getstudents()
        {
            return Ok(await _context.Students.ToListAsync());
        }

    }
}
