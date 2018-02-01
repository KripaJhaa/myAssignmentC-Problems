using print_tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_tree
{
    

    //mukesh0911993@gmail.com

    

    class Program
        {
            static void Main(string[] args)
            {

                binaryTree<int> mytreeHead = new binaryTree<int>();

                mytreeHead.Add( 1);
                mytreeHead.Add( 2);
                mytreeHead.Add( 3);
                mytreeHead.Add( 4);
                mytreeHead.Add( 5);
                mytreeHead.Add( 6);
                mytreeHead.Add( 7);
                mytreeHead.Add( 8);


            //-------------------------------------

            /*
             * 
             *          1
             *       2     3
             *      4 5   6 7
             *    8
             *    
             *    
             * */

            binaryTree<int> head = new binaryTree<int>();

            head.root = new node<int>(1);

            head.root.left = new node<int>(2);
            head.root.right = new node<int>(3);
            head.root.left.left = new node<int>(4);
            head.root.left.right = new node<int>(5);
            head.root.right.left = new node<int>(6);
            head.root.right.right = new node<int>(7);
            head.root.left.left.left = new node<int>(8);



           // Console.WriteLine("..................Preorder Traversal ............\n\n");
            // mytreeHead.getPreOrder(mytreeHead.root);
           // head.getPreOrder(head.root);


            
             head.LevelOrder(head.root);
             head.spiralOrder(head.root);


             Console.Read();
            }

        }
    }



    

