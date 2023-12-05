class Exercise23
{
    static void Main()
    {

        Console.WriteLine("Input a sentence");
        string? stringSentence = Console.ReadLine();
        Console.WriteLine(LowerIt(stringSentence));

    }
    public static string LowerIt(string sentence)
    {

        string lowerSentence;
        lowerSentence = sentence.ToLower();
        return lowerSentence;
    }
}
