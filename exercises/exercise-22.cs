class Exercise22
{
    static void Main()
    {

        Console.WriteLine("Input first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        bool trueOrFalse = CalculateThis(number1);
        Console.WriteLine(trueOrFalse);

    }
    public static bool CalculateThis(int num1)
    {

        bool result = Math.Abs(num1 - 100) <= 20 || Math.Abs(num1 - 200) <= 20;
        return result;

    }
}
