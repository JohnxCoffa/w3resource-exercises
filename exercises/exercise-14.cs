class Exercise
{
    static void Main()
    {
        double celsius;
        Console.WriteLine("Enter the amount of celsius:");
        celsius = Convert.ToDouble(Console.ReadLine());
        double kelvin = celsius + 273;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Kelvin = {kelvin}");
        Console.WriteLine($"Fahrenheit= {fahrenheit}");

    }
}
