using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No :");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No :");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            int Result = Convert.ToInt32(Console.ReadLine());
            switch (Result)
            {
                case 1:
                    Console.WriteLine("Addition of two Numbers :" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Substractiom of two Numbers :" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication of two Numbers :" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division of two Numbers :" + (num1 / num2));
                    break;
                    default:
                    Console.WriteLine("Choice in between 1 to 4");
                    break;
            }
            Console.ReadLine();
        }
    }
}
