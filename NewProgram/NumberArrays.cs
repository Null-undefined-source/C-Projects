class NumberArrays
{
    private int[] arr;
    public void Run()
    {
        while (true)
        {
            Console.Write("Enter a command(q to quit or size of array): ");
            string s = Console.ReadLine();
            if (s.ToLower().Equals("q"))
            {
                Console.WriteLine("Terminating...");
                break;
            }
            if (int.TryParse(s, out int num))
            {
                if (num <= 0)
                {
                    Console.WriteLine("Enter a number greater than 0");
                }
                else
                {
                    arr = new int[num];
                    ArrayInput(num);
                    Console.WriteLine("The sum is {0}\nThe Average is {1}", ArrSum(out double Avg), Avg);
                    Console.WriteLine("The max is {0}\nThe min is {1}", arr.Max(), arr.Min());
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine();
        }
    }

    private void ArrayInput(int size)
    {
        for (int i = 0; i < size; i++)
        {
        Input:
            Console.Write("Enter a number: ");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int InputNum))
            {
                arr[i] = InputNum;
            }
            else
            {
                Console.WriteLine("Enter a valid number");
                goto Input;
            }
        }
    }
    private int ArrSum(out double Avg)
    {
        int Sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Sum += arr[i];
        }
        Avg = (double)Sum / arr.Length;
        return Sum;
    }
}