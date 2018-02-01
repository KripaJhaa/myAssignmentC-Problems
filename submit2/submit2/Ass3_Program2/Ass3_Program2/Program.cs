using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3_Program2
{
    class Program
    {
        static void Main(string[] args)
        {

            int lower_Bound = 1;
            int upper_Bound = 100;

            for (int i = 0; i < 10; i++)
            {
                lower_Bound = ReadNumber(lower_Bound, upper_Bound);
            }

        }

       public  static int ReadNumber(int lower, int upper)
        {

            Console.WriteLine("Enter the number in  range: form 1 to 100 ");
            int num = int.Parse(Console.ReadLine());
            try
            {


                if (num <= lower || num >= upper)
                {
                    throw new ArithmeticException();
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("Non number text");
                return lower;
            }

            catch (ArithmeticException)
            {
                Console.WriteLine("Invalid number");
                return upper;
            }
            return num;
        }
    }
}
