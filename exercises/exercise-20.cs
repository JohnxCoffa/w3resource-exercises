class Exercise20
{
    static void Main()
    {
        Console.WriteLine("Input first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int total = MyFunc(number1, number2);
        Console.WriteLine(total);

    }
    public static Int32 MyFunc(int num1, int num2)
    {
        int result;

        if (num1 > num2)
        {
            result = (num1 - num2) * 2;
        }
        else
        {
            result = Math.Abs(num1 - num2);
        }

        return result;
    }
}
