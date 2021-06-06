using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        int sizeOfAnimal = 0;
        public int SizeOfAnimal { get => sizeOfAnimal; set => sizeOfAnimal = value; }

        private string breathing()
        {
            return "I'm Ok";
        }
        private string move()
        {
            return "Go Go Go!"; 
        }
    }
}
