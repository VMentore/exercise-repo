using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            int a = int.Parse(Console.ReadLine());
           
                for (int i = 0; i <a; i++)
                {
                    decimal n = decimal.Parse(Console.ReadLine());
                    sum += n;
                }
         
           
            Console.WriteLine(sum);

        }
    }
}
