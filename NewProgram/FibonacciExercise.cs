class FibonacciExercise
{
    public void Run()
    {
        while (true)
        {
            Console.Write("Enter a command(q to quit or number): ");
            string s = Console.ReadLine();
            if (s.ToLower().Equals("q"))
            {
                Console.WriteLine("Terminating...");
                break;
            }
            if (int.TryParse(s, out int num))
            {
                if (num < 0)
                {
                    Console.WriteLine("A positve number is required");
                }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write("{0}\t", Fibonacci(i));
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine();
        }
    }   
    
    private long Fibonacci(int num)
    {
        if(num <= 1)
        {
            return num;
        }
        return Fibonacci(num - 1) + Fibonacci(num - 2);
    }
}