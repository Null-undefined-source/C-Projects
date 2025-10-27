using System.Reflection.Metadata.Ecma335;

namespace NewProgram;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a command(q to quit or number): ");
            string s = Console.ReadLine();
            if(s.ToLower().Equals("q"))
            {
                Console.WriteLine("Terminating...");
                break;
            }
            if (int.TryParse(s, out int num))
            {
                if (num == 0)
                {
                    Console.WriteLine("It is zero");
                    continue;
                }
                if (IsEven(num))
                {
                    Console.WriteLine("it is Even");
                }
                else
                {
                    Console.WriteLine("It is Odd");
                }
                if (num < 0)
                {
                    Console.WriteLine("It is negative");
                    continue;
                }
                Console.WriteLine("It is Positive");
                if (IsPrime(num))
                {
                    Console.WriteLine("It is prime");
                }
                else
                {
                    Console.WriteLine("It is Composite");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }

    private static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    private static bool IsPrime(int num)
    {
        if(num < 2)
        {
            return false;
        }
        for (int i = 2; i * i <= num / 2; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

}
