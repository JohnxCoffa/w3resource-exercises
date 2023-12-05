class Exercise21
{
    static void Main()
    {
        Console.WriteLine("Input first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        bool trueOrFalse = CalculateThis(number1, number2);
        Console.WriteLine(trueOrFalse);

    }
    public static bool CalculateThis(int num1, int num2)
    {
        int result;

        result = num1 + num2;

        if (num1 == 20 || num2 == 20 || result == 20)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
