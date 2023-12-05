class Exercise24
{
    static void Main()
    {

        Console.WriteLine("Input a sentence");
        string? stringSentence = Console.ReadLine();
        string? result = CountIt(stringSentence);
        Console.WriteLine(result);

    }
    public static string CountIt(string sentence)
    {
        
        // maak een variable om het langste woord in op te slaan
        string longestWord = "";

        // split de zin via spaties en doe het dan in een array
        string[] words = sentence.Split(' ');

      
        foreach (var word in words) 
        {
            // als het woord langer is dan het langste woord dat eerst op 0 staat
            // doe het langste woord in de variable in longestword
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        // kick back de longestWord
        return longestWord;
    }
}
