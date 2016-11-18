using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayorQue100
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numeroOK = false;
            double var1, var2;
            var1 = 0;
            var2 = 0;

            while (!numeroOK)
            {
                Console.WriteLine("Escribe SOLO un número mayor que 100.");
                Console.WriteLine("Escribe el primer número:");
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escribe el segundo número:");
                var2 = Convert.ToDouble(Console.ReadLine());
                if (((var1 > 100) && (var2 > 100)) ^ ((var1 <= 100) && (var2 <= 100)))
                {
                    numeroOK = true;
                    Console.WriteLine("Solo quiero un número mayor que 100.");
                }
                else
                {
                    Console.WriteLine($"Tus números son {var1} y {var2}");
                }
            }
            Console.ReadKey();
        }
    }
}
            