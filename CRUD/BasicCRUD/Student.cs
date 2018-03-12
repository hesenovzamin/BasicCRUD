using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD
{
    class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public int Age;
        public Student(string _name,string _surname,int _age,int id)
        {
            Name = _name;
            Surname = _surname;
            Age = _age;
            Id = id;
        }
    }
}
