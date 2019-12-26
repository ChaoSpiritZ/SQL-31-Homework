using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_31
{
    public class Classroom
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int NumberOfStudents { get; set; }
        public int NumberOfVIP { get; set; }
        public float AgeAverage { get; set; }
        public string MostPopularCity { get; set; }
        public int OldestVIP { get; set; }
        public int YoungestVIP { get; set; }

        public override string ToString()
        {
            return $"Classroom --- ID: {Id}, Name: {Name}, Code: {Code}, Number of Students: {NumberOfStudents}, Number of VIP: {NumberOfVIP}, Age Average: {AgeAverage}, " +
                $"Most Popular City: {MostPopularCity}, Oldest VIP: {OldestVIP}, Youngest VIP: {YoungestVIP}";
        }
    }
}
