using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQL_31
{
    public class SchoolDAO : ISchoolDAO
    {
        public string path = @"C:\Users\user\Desktop\SQLite\SQLite DBs\sql31.db";

        public Dictionary<Classroom, List<Student>> GetMapClassToStudentsDictionary()
        {
            Dictionary<Classroom, List<Student>> MapClassToStudentsDictionary = new Dictionary<Classroom, List<Student>>();
            using (SQLiteConnection con = new SQLiteConnection($"Data Source = {path}; Version = 3;"))
            {
                con.Open();
                using(SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Class", con))
                {
                    using(SQLiteDataReader cReader = cmd.ExecuteReader())
                    {
                        while (cReader.Read())
                        {
                            Classroom c = new Classroom()
                            {
                                Id = (Int64) cReader["Id"]
                            };
                            List<Student> students = new List<Student>();
                            //Console.WriteLine($"{c.Id}");
                            using (SQLiteCommand cmd2 = new SQLiteCommand($"SELECT * FROM Students Where ClassId = {c.Id}", con))
                            {
                                using(SQLiteDataReader sReader = cmd2.ExecuteReader())
                                {
                                    while (sReader.Read())
                                    {
                                        Student s = new Student()
                                        {
                                            Id = (Int64)sReader["Id"],
                                            Name = (string)sReader["Name"],
                                            Age = (Int64)sReader["Age"],
                                            AddressCity = (string)sReader["Address_City"],
                                            VIP = (string)sReader["VIP"],
                                            ClassId = (Int64)sReader["ClassId"]
                                        };
                                        students.Add(s);
                                        //Console.WriteLine($"{sReader["Id"]}, {sReader["Name"]}, {sReader["Age"]}, {sReader["Address_City"]}, {sReader["VIP"]}, {sReader["ClassId"]}");
                                    }
                                }
                            }
                            MapClassToStudentsDictionary.Add(c, students);
                        }
                        
                    }
                }
            }
            return MapClassToStudentsDictionary;
        }

        public List<Student> GetStudentsFromClass(int ClassId)
        {
            List<Student> students = new List<Student>();
            using(SQLiteConnection con = new SQLiteConnection($"Data Source = {path}; Version = 3;"))
            {
                con.Open();
                using(SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Students Where ClassId = {ClassId}", con))
                {
                    using(SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student s = new Student()
                            {
                                Id = (Int64)reader["Id"],
                                Name = (string)reader["Name"],
                                Age = (Int64)reader["Age"],
                                AddressCity = (string)reader["Address_City"],
                                VIP = (string)reader["VIP"],
                                ClassId = (Int64)reader["ClassId"]
                            };
                            students.Add(s);
                        }
                    }
                }
            }
            return students;
        }
    }
}
