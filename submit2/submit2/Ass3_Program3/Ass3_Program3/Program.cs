using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3_Program3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                uint a = uint.Parse(Console.ReadLine());

                double result = Math.Sqrt(a);

                if (double.IsNaN(result))
                {
                    throw new NotFiniteNumberException("Invalid number");
                }

                Console.WriteLine(result);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }

            catch (ArithmeticException)
            {
                Console.WriteLine("Invalid number");
            }

            finally
            {
                Console.WriteLine("Good bye");
            }
            Console.Read();
        }
    }
}
