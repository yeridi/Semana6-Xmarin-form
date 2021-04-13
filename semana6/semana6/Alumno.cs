using System;
using System.Collections.Generic;
using System.Text;

namespace semana6
{
    public class Alumno
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {get;set;}

        public Alumno(string firstname, string lastname, int age) {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }
    }
    public class UserGroupM : List<Alumno> { 
        public string GroupName { get; private set; }

        public UserGroupM(string groupname, List<Alumno> source) : base(source) {
            GroupName = groupname;
        }
    }
}
