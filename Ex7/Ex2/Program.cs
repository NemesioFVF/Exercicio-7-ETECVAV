using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de 'a': ");
            Int32 a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de 'b': ");
            Int32 b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de 'c': ");
            Int32 c = Convert.ToInt32(Console.ReadLine());
            Double dl = Math.Pow(b, 2);
            if (dl < 0)
            {
                Console.Write("Não possui raíz");
                Console.ReadKey();
            }
            else
            {
                if (dl == 0)
                {
                    Double x = (-b + Math.Sqrt(dl)) / (2 * a);
                    Console.Write("Possui uma raíz, de valor: " + x);
                    Console.ReadKey();
                }
                else
                {
                    Double xa = (-b + Math.Sqrt(dl)) / (2 * a);
                    Double xb = (-b - Math.Sqrt(dl)) / (2 * a);
                    Console.Write("Possui duas raízes, de valores: " + xa + " e " + xb);
                    Console.ReadKey();
                }
            }
        }
    }
}
