using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapicore20.Data;
using webapicore20.Models;
using webapicore20.Interfaces;
using webapicore20.Repositories;

namespace webapicore20.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolrepository;

        public SchoolService(ISchoolRepository schoolrepo)
        {
            _schoolrepository = schoolrepo;
        }

        public IEnumerable<Student> GetStudent()
        {
            return _schoolrepository.GetStudent();
        }
    }
}
