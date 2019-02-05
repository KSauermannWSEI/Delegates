using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> cw = Console.WriteLine;
            Action<int, int> x = Sum;
            Func<int> cr = Console.Read;
            cw("1");
            cw += r => Console.WriteLine(r + r);
            x += (a, b) => Console.WriteLine(a - b);
            x += (a, b) =>
            {
                if (a > 1 && b != 0)
                {
                    Console.WriteLine(a % b);
                }
                if (a % b == 0)
                {
                    Console.WriteLine("Podzielana przez 2");
                }
            };
            cr = () => Console.Read();

            cw("2");
            cw -= Console.WriteLine;
            cw("3");
            Console.WriteLine();
            x(11, 3);
            cr();

            //List<Roman> romany = new List<Roman>();
            //romany.Add(new Roman
            //{
            //    Name = "Prawdziwy Roman"
            //});
            //Roman roman = new Roman();
            //roman.Name = "Romana";
            //romany.Add(roman);
        }
        class Roman
        {
            public string Name { get; set; }
        }
        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //static void writeNumber(string strNumber)
        //{
        //    //Jakaś logika
        //    Console.WriteLine($"Podany string jest liczbą: {strNumber}");
        //}
    }
}
