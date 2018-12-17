using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Donnez la valeur de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de B:");
            b = int.Parse(Console.ReadLine());

            a = a + 33;
            b++;

            int Total = a / b;
            Console.WriteLine("Voici la division" , +Total);
            Console.ReadLine();
        }
    }
}
