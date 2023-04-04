using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bb203_home_Tasks
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public int Id;
        public string UserName;

        public Student(string name,string surname,int id)
        {
            Name = name;
            Surname = surname;
            Id = id;
            UserName = name.ToLower() +surname.ToLower();
        }


    }
}
