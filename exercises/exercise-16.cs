class Exercise16
{
    static void Main()
    {
        Console.WriteLine(SwitchItUp("W3resource"));
        Console.WriteLine(SwitchItUp("Python"));
        Console.WriteLine(SwitchItUp("X"));
    }
    public static String SwitchItUp(string givenString)
    {
        if (givenString.Length > 1)
        {
            string temp = givenString.Substring(0, 1);
            string temp1 = givenString.Substring(1);
            return temp1 + temp;
        }
        else
        {
            return givenString;
        }
    }
}
