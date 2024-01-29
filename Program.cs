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

            Random rnd1 = new Random();
            int val3 = rnd1.Next(3);
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

            Random rnd2 = new Random();
            int val = rnd2.Next(3);
            switch (val)
            {
                case 0:
                    Console.WriteLine("Absent");
                    break;
                case 1:
                    Console.WriteLine("Part Time");
                    break;
                case 2:
                    Console.WriteLine("Full Time");
                    break;
            }
            Console.ReadKey();

            int val4 = 20 * 8 * 20;
            Console.WriteLine(val4);
            Console.ReadLine();

            Random rnd3 = new Random();
            int days = 0, hours = 0;
            while (days < 20 && hours < 100)
            {
                int val5 = rnd3.Next(3);
                hours += val * 4;
                days++;
                Console.WriteLine($"val : {val}  Hours : {hours} days : {days}");
            }
            int wages = hours * 20;
            Console.WriteLine($"Wages : {wages}");
            Console.ReadKey();

        }
    }
}