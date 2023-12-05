class Exercise10
{
    static void Main()
    {
        int[] numbers = new int[3];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Enter number {i + 1}");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result1 = (numbers[0] + numbers[1]) * numbers[2];
        int result2 = (numbers[0] * numbers[1]) + (numbers[1] * numbers[2]);
        Console.WriteLine($"(x + y) * z = {result1}");
        Console.WriteLine($"(x * y) + (y * z) {result2}");
    }
}
