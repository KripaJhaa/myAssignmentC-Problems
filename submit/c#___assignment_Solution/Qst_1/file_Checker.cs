using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isFileExist
{
   public  class file_Checker
    {


        public  bool IsFileExist(string file_name, string folder_path)
        {
            bool flag = false;
            try
            {
                foreach (string d in Directory.GetDirectories(folder_path))
                {

                    Console.WriteLine(d);
                    IsFileExist(file_name, d);
                    foreach (var file in Directory.GetFiles(d))
                    {
                        Console.WriteLine("File " + file);
                        Console.WriteLine("????" + d + file_name);

                        if (file.Equals(d + "\\" + file_name))
                        {
                            flag = true;
                            return true;
                        }
                    }
                }


                if (flag) return true;


                return false;
            }
            catch (System.Exception e)
            {
                Console.Write("<Catch>" + folder_path);
                return false;
            }

        }
    }
}
