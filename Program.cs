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

            int val2 = 8 * 20;
            Console.WriteLine(val2);
            Console.ReadLine();

            Random rnd = new Random();
            int val3 = rnd.Next(3);
            if (val3 == 0)
            {
                Console.WriteLine("Absent");
            }
            else if (val3 == 1)
            {
                Console.WriteLine("Part Time");
            }
            else
            {
                Console.WriteLine("Full Time");

            }
            Console.ReadKey();


        }
    }

}