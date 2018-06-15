using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programarepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class c2 = new Class2();
            c1.Saludo();
            Console.WriteLine(c2.Suma(1, 3));
        }
    }
}
