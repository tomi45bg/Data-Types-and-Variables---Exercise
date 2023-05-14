using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int result = 0;
            int operation1 = num1 + num2;
            int operation2 = operation1 / num3;
            int operation3 = operation2 * num4;
            result = operation3;

            Console.WriteLine(result);
        }
    }
}