using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_num
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter n1 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2 : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" the perfect number between {0} and {1} are", n1, n2);

            for (int i = n1; i <= n2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine(i);
            }

            Console.ReadKey();


    }
    }
}
