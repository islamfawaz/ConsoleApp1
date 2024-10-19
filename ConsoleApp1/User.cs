using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {

        public  int Id { get; set; }
        public  string Name { get; set; }

        public  string Role { get; set; }
        public User(int id,string name,string role)
        {
            Id = id;
            Name = name;
            Role=role;
        }

        public override string ToString()
        {
            return $"Welcome: {Name}, Your ID: {Id}, You are a {Role}.";
        }
    }
}
