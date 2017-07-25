using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapicore20.Data;
using Microsoft.EntityFrameworkCore;
using webapicore20.Interfaces;

namespace webapicore20.wwwroot
{
    [Route("api/[controller]/[action]")]
    public class StudentsController : ControllerBase
    {
        private readonly ISchoolService _SchoolService;

        public StudentsController(ISchoolService SchoolService)
        {
            _SchoolService = SchoolService; 

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
        public IActionResult Getstudents()
        {
            return Ok(_SchoolService.GetStudent());
        }

    }
}
