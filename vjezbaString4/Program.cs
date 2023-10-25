using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaString4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            Console.WriteLine("Upišite neki tekst: ");

            tekst = Console.ReadLine();

            string[] rijec = tekst.Split(' ');

            string zadnja = rijec[rijec.Length - 1];

            string prva = tekst.Substring(0, tekst.IndexOf(' '));

            Console.WriteLine(prva);

            Console.WriteLine(zadnja);

            Console.ReadKey();
        }
    }
}
