class FactorialExercise
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
                Console.WriteLine("The factorial is {0}", Factorial(num));
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }
    
    private long Factorial(int num)
    {
        if (num <= 1)
        {
            return 1;
        }
        return num * Factorial(num - 1); 
    }
}