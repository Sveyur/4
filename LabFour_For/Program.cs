using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFour_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N больше 0:  ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int n2 = 0, i=1; 2 * N - 1 >= i; )
            {
                n2 += i;
                i += 2;
                Console.WriteLine(n2);
            }          
           
            Console.ReadKey();
        }
    }
}
