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
                if (IsPrime(num))
                {
                    Console.WriteLine("It is Prime");
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
            Console.WriteLine();
        }

    }

    private static bool IsEven(int num)
    {
        if (num % 2 == 0)
            return true;
        return false;
    }

    private static bool IsPrime(int num)
    {
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

}
