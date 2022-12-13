using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ArrayClass
{
    internal class Student
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public string phone = "994";
        public int zipCode;

        public string GetFullName()
        {
            return name + "  " + surname;
        }


        public string GetFullData()
        {
            return $"{name} {surname} {age} {address} {phone} {zipCode}";
        }
    }
}
