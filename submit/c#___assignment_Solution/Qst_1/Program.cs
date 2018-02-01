using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isFileExist
{
    class Program
    {
        static bool flag = false;

        static private string file_name, folder_path;

        static void Main(string[] args)
        {
            file_Checker obj = new file_Checker();
            

               int t = 1;
                do
                {


                     file_name = Console.ReadLine();
                     folder_path = Path.GetFullPath(file_name);

                    folder_path = "C:\\Users\\Public";
                    Console.WriteLine(folder_path);


                    if (obj.IsFileExist(file_name, folder_path))
                        Console.WriteLine("folder found");
                    else
                        Console.WriteLine("Not found");


                    Console.WriteLine("Do you want to continue?");
                    t = Convert.ToInt32(Console.ReadLine());
                    
                } while (t == 1);

            }

        }
    }





