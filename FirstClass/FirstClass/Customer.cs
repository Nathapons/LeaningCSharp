using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Customer
    {
        string name = "";
        string lastName = "";
        string address = "";
        string email = "";

        // public string ชื่อ Excapsolation { get => name; set => name = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
