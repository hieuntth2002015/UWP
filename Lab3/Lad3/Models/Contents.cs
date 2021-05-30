using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lad3.Models
{
    class User
    {
        private string name;
        

        public User(string name )
        {
            Name = name;
            
        }

        public string Name // properties
        {
            get => name;
            set => name = value;
        }

    }
}
