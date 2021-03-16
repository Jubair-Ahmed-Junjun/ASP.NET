using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectApp
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string GetFullName()
        {
            string fullName = firstName + "" + middleName + "" + lastName;
            return fullName;
        }
    }
}
