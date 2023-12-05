class Exercise12
{
    static void Main()
    {
        int digit;
        Console.WriteLine("Enter a digit:");
        digit = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 4; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{digit} {digit} {digit} {digit}");
            }
            else
            {
                Console.WriteLine($"{digit}{digit}{digit}{digit}");
            }
        }
    }
}
