using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cache_prog
{


    class cacheMgmt<T>
    {
        T data;
        public cacheMgmt(T val)
        {
            this.data = val;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;

            Console.WriteLine("\n\nEnter the cache size\n\n");

            size = Convert.ToInt32(Console.ReadLine());

            List<string> list = new List<string>();

            Dictionary<string,int> dic = new Dictionary<string,int>();

            bool inp = false;
            int index = 0;

            /*
             * 
             * 
             * 
             * 1 2 3 4 --2
             * 1 3 4 2 --5
             * 5 3 4 2 --5
             * 3 4 2 5
             * 
             * 
             * */

            do
            {

                Console.Write("\nEnter 1 to insert  2 to display \n");

                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {

                    case 1:

                        Console.WriteLine("\n Enter the element to the cache \n\n");
                        string val = Console.ReadLine();

                        if (size > list.Count)
                        {
                            if (!dic.ContainsKey(val))
                            {
                                list.Add(val);
                                dic.Add(val,index);
                                
                            }
                            else
                            {
                               int  inde= dic[val];
                                
                                list[inde] = "@-1";
                                list.Add(val);
                                dic.Remove(val);
                                dic.Add(val, index);

                            }
                            
                        }
                        else
                        {
                            if (!dic.ContainsKey(val))
                            {
                                list[0] = "@-1";
                                list.Add(val);
                                dic.Add(val, index);
                               
                            }
                            else
                            {
                                int inde = dic[val];
                                

                                list[inde] = "@-1";
                                list.Add(val);

                                dic.Remove(val);
                                dic.Add(val, index);

                            }
                        }

                        index++;

                        break;

                    case 2:
                        Console.WriteLine("----Display list----");

                        for(int i = 0; i < list.Count; i++)
                        {
                            if (list[i] != "@-1") {
                                Console.WriteLine(list[i]+" ");
                            }
                        }

                        break;

                    default:
                        Console.WriteLine("\n Wrong Option \n");
                        break;
                }

                Console.WriteLine("\n\nWnat to enter more  press 1\n\n");
               int inpt = Convert.ToInt32(Console.ReadLine());

                if (inpt == 1) { inp = true; }
                else { inp = false; }

            } while (inp == true);

        }
    }
}
