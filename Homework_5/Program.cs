class Program
{

    private static Dictionary<char, int> CharCount(string s)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {

            if (dictionary.ContainsKey(s[i])) // Проверяет есть ли такой ключ уже
                dictionary[s[i]]++; // +1
            else
                dictionary.Add(s[i], 1);
        }

        return dictionary;
    }

    public static void Main(string[] args)
    {
        Console.Write("Pleasy, type line: ");
        string line = Console.ReadLine();

        Dictionary<char, int> result = CharCount(line);

        foreach (var item in result)
        {
            Console.Write("{'" + item.Key + "', " + item.Value + "} ");
        }
    }
}