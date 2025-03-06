using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FitnessConsole.Objects
{
    class Account(int id,
        string username,
        string password)
    {
        public int ID { get; set; } = id;

        public string Username { get; set; } = username;

        public string Password { get; set; } = password;
    }
}
