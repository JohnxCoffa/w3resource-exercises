class Exercise15
{
    static void Main()
    {
        string name = "w3resource";

        string newName = name.Remove(1, 1);
        string newName1 = name.Remove(name.Length - 1);
        string newName2 = name.Remove(0, 1);
        Console.WriteLine(newName);
        Console.WriteLine(newName1);
        Console.WriteLine(newName2);

    }
}