using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_31
{
    interface ISchoolDAO
    {
        Dictionary<Classroom, List<Student>> GetMapClassToStudentsDictionary();
        List<Student> GetStudentsFromClass(int ClassId);
    }
}
