using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesandVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int years = n * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            int minutes = hours * 60;
            Console.WriteLine("{0} centuries = {1} years = {2:f0} days = {3} hours = {4} mintes", n,years,days,hours,minutes);
        }
    }
}
