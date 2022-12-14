class Program
{
    public static List<int> evenNumbers(int[] array)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result.Add(array[i]);
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Console.Write("Array length: ");
        int arraylenght = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("___________________");

        int[] array = new int[arraylenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} element: ", i + 1);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("___________________");

        Console.WriteLine("List elements: ");
        foreach (var item in evenNumbers(array))
        {
            Console.Write(" " + item);
        }
    }
}
