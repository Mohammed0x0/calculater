using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= i; i++)
            {
                int total;
                Console.WriteLine("Select Type of calculation : \n  1 \t is +  \n  2 \t is - \n  3 \t is / \n  1 \t is * \n  0 to exit \t");



                int type = Convert.ToInt32(Console.ReadLine());




                Console.WriteLine("enter first number \n");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter socend number \n");
                int num2 = Convert.ToInt32(Console.ReadLine());


                switch (type)
                {
                    case 1:
                        total = num1 + num2;
                        Console.WriteLine("total:" + total);
                        break;
                    case 2:

                        total = num1 - num2;
                        Console.WriteLine("total:" + total);
                        break;
                    case 3:

                        total = num1 / num2;
                        Console.WriteLine("total:" + total);
                        break;
                    case 4:

                        total = num1 * num2;
                        Console.WriteLine("total:" + total);
                        break;
                    default:

                        break;
                }
                if (type == 0)
                {
                    break;
                }
            }

        }
    }
}
