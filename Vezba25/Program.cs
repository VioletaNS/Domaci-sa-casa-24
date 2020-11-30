using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba25
{
    class Program
    {
        static void Main(string[] args)
        {
            string Gradovi;
            Console.Write("Unesite Grad>");
            Gradovi = Console.ReadLine();
            Console.Write("Unesite Grad>");
             Gradovi= Console.ReadLine();
            Console.Write("Unesite Grad>");
            Gradovi = Console.ReadLine();
            FileMenagment.WriteList(Gradovi);
        }
    }
}
