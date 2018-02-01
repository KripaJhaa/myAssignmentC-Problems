using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  
 * by ksj...
 * 
 * */

namespace Ass3_program1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the file path:");
                string filepath = Console.ReadLine();

                string text = File.ReadAllText(filepath);
                Console.WriteLine(text);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

            catch (ArgumentException)
            {
                Console.WriteLine(" Invalid file path.");
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found.");
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Cannot Access the Path entered.");
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Input.");
            }
        }
    }
}
