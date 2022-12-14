class Program
{
    private static Dictionary<char, int> CharCount(string s)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();

        int[] counts = new int[s.Length];

        foreach (char c in counts)
        {
            counts[c] = 0;
        }

        for (int i = 0; i < s.Length; i++)
        {
            char tmp = s[i];

            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] == tmp)
                {
                    counts[i]++;
                }
            }

            if (counts[i] < 1)
            {
                dictionary.Add(tmp, counts[i]);
            }
            else
            {
                try
                {
                    dictionary.Add(tmp, counts[i]);
                }
                catch (ArgumentException)
                {
                    //do nothing
                }
            }
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