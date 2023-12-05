
class Exercise
{
    static void Main()
    {
        int digit;
        Console.WriteLine("Enter a digit:");
        digit = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 5; i++) // row
        {
            for (int j = 0; j < 3; j++)  // number      
            {
                // selects the second number of the second row
                if (j == 1 && (i == 1 || i == 2 || i == 3))
                {
                    // write nothing
                    Console.Write(" ");
                }
                else
                {
                    // write the number
                    Console.Write($"{digit}");
                }
            }
            // new line for new row
            Console.WriteLine();
        }

    }
}
