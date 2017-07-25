using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapicore20.Data;
using webapicore20.Interfaces;
using webapicore20.Models;

namespace webapicore20.Repositories
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly SchoolContext _context;

        public SchoolRepository(SchoolContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Student> GetStudent()
        {
            return _context.Students.AsEnumerable();
        }
    }
}
