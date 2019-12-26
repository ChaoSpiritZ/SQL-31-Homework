using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_31
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDAO DAO = new SchoolDAO();
            //Dictionary<Classroom, List<Student>> aList = DAO.GetMapClassToStudentsDictionary();
            List<Student> students = DAO.GetStudentsFromClass(3);
            students.ForEach(s => Console.WriteLine(s));
        }
    }
}
