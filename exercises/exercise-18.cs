class Exercise18
{
    static void Main()
    {
        Console.WriteLine("Input first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        bool result = SwitchItUp(number1, number2);

        Console.WriteLine($"is one number negative and the other positive + {result}");
    }
    public static bool SwitchItUp(int num1, int num2)
    {
        return ((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0));
    }
}
