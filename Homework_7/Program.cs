class Program
{

    public static bool equality(string firstLine, string secondLine)
    {
        
        return firstLine.IndexOf(secondLine) != -1;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter first line: ");
        string firstLine = Console.ReadLine();

        Console.Write("Enter second line: ");
        string secondLine = Console.ReadLine();

        Console.WriteLine(equality(firstLine, secondLine));

    }
}
