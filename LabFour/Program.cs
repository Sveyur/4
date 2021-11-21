using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N больше 0:  ");
            int N = Convert.ToInt32(Console.ReadLine());
            int N2 = 0;
            int I = 1;
            do
            {
                N2 += I;
                I += 2;
                Console.WriteLine(N2);
            } while (2 * N - 1>= I);
            Console.ReadKey();
        }
    }
}
