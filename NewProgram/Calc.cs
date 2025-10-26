using System;

namespace Calc
{
    public class Calc
    {
        public void Start()
        {
            char symbol;
            float num1, num2;

            Console.Write("Enter two numbers: ");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());

            Console.Write("Enter the operator: ");
            symbol = Console.ReadLine().ElementAt(0);

            Console.WriteLine($"\nThe result is: {Calculate(symbol, num1, num2)}");
        }

        private static float? Calculate(char c, float n1, float n2)
        {
            switch (c)
            {
                case '+':
                    return n1 + n2;
                case '-':
                    return n1 - n2;
                case '*':
                    return n1 * n2;
                case '/':
                    return n1 / n2;
                default:
                    Console.WriteLine("Invalid oprator");
                    return null;
            }
        }
    }
}