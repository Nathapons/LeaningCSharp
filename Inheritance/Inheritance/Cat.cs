using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cat : Animal
    {
        string name;
        public string Name { get => name; set => name = value; }
        public string cry()
        {
            return "Meaowwww !";
        }
        public string breath()
        {
            return "breath! ";
        }

        public string move()
        {
            return "Super runnnn!!!";
        }
    }
}
