using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int val1 = random.Next(2);
            if (val1 == 0)
            {
                Console.WriteLine("Absent");
            }
            else
            {
                Console.WriteLine("Present");
            }
            Console.ReadKey();

            int val = 8 * 20;
            Console.WriteLine(val);
            Console.ReadLine();

        }
    }

}