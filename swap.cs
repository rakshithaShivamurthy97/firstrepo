using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class swap
    {
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"before swapping num1={num1} and num2={num2}");
            swapno(ref num1,ref num2);
            Console.WriteLine($"after swapping num1={num1} and num2={num2}");
        }
       private static void swapno(ref int n1,ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
