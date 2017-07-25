using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapicore20.Models;

namespace webapicore20.Interfaces
{
    public interface ISchoolService
    {
        IEnumerable<Student> GetStudent();
    }
}
