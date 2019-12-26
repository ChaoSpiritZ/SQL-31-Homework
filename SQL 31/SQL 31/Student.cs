using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_31
{
    public class Student
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public Int64 Age { get; set; }
        public string AddressCity { get; set; }
        public string VIP { get; set; }
        public Int64 ClassId { get; set; }

        public override string ToString()
        {
            return $"Student --- ID: {Id}, Name: {Name}, Age: {Age}, Address City: {AddressCity}, VIP: {VIP}, Class ID: {ClassId}";
        }
    }
}
