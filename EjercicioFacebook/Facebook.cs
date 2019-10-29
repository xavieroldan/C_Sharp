using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacebook
{
    class Facebook
    {
        private string _Name;
        private int _Age;
        private string _Password;

        public Facebook(string name, int age, string password)
        {
            Name = name;
            Age = age;
            Password = password;
        }

        public Facebook(string name) : this (name, 0, "1234")
        {
            Name = name;
        }

        public string Name { get => _Name; set => _Name = value; }        
        public int Age { get => _Age; set => _Age = value; }
        public string Password { get => _Password; set => _Password = value; }
    }

    
}
