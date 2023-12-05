class Exercise17
{
    static void Main()
    {
        Console.WriteLine("Input a string:");
        string newSentence = SwitchItUp(Console.ReadLine());
        Console.WriteLine(newSentence);
    }
    public static String SwitchItUp(string givenString)
    {
        if (givenString.Length > 1)
        {
            string temp = givenString.Substring(0, 1);
            
            return temp + givenString + temp;
        }
        else
        { 
            return givenString;
        }
    }
}
