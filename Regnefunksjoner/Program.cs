using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regnefunksjoner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            Console.WriteLine(add(33,77));

            //Oppg 2
            Console.WriteLine(sub(13,7));
            Console.WriteLine(div(13,29));

            //Oppg 3
            Console.WriteLine(inToCm(13));

            //Oppg 4
            skrivBeregninger();

            Console.ReadLine();
        }

        //Oppg 1
        static double add(double a, double b)
        {
            return a + b;
        }

        //Oppg 2
        static double sub(double a, double b)
        {
            return a - b;
        }

        static double div(double a, double b)
        {
            return a / b;
        }

        //Oppg 3
        static double inToCm(double a)
        {
            return a * 2.54;
        }

        //Oppg 4.1
        static void skrivBeregninger()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Tall 1:");
                    double i1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Tall 2:");
                    double i2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{i1} + {i2} = {add(i1,i2)}");
                    Console.WriteLine($"{i1} - {i2} = {sub(i1, i2)}");
                    Console.WriteLine($"{i1} / {i2} = {div(i1, i2)}");

                    //Oppg 4.2
                    Console.WriteLine("Tall 3:");
                    double i3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{i3}in = {inToCm(i3)}cm");
                    break;
                }
                catch
                {
                    Console.WriteLine("Vennligst oppgi et tall");
                }
            }
        }
    }
}
