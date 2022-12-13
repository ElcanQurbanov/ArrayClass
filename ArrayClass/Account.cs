using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{ 
    internal class Account
    { 
        public string username;
        public string password;


        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }



        internal void Login()
        {
            if (username == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Ugurludur");
            }
            else
            {
                Console.WriteLine("Email ve ya Password sehvdir");
            }
        }
    }




    



}
