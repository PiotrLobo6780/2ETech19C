using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad 1
            /*
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            //Zad 2
            /*
            int a = int.Parse(Console.ReadLine());
            if (a>=100 && a<1000 && a%17==0)
            {
                Console.WriteLine("JEST");
            }
            else
            {
                Console.WriteLine("NIE JEST");
            }
            */

            //Zad 3
            /*
            int a = int.Parse(Console.ReadLine());
            if (a>=18)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            //Zad 4
            /*
            const int LIMIT = 20;
            int waga = int.Parse(Console.ReadLine());

            if (waga < LIMIT)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            //Zad 5
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a<c) && (b>c) || (b<c) && (a>c))
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            //Zad 6
            /*
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            if ((Math.Pow(a,p) - a) % p == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            //Zad 7
            int p = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            if ((p + 3*s) >= k)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
        }
    }
}
