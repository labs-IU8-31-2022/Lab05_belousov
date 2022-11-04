using Lab05_belousov;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new(1, 2, 3, 4, 5);
        Console.WriteLine($"List is:");
        for (uint i = 0; i < list.Count; ++i)
        {
            Console.Write($"{list[i]} ");
        }
        Console.WriteLine("");
        Console.WriteLine($"Size is {list.Count}; Capacity is {list.Capacity}");
        list.Add(20);
        for (uint i = 0; i < list.Count; ++i)
        {
            Console.Write($"{list[i]} ");
        }
        Console.WriteLine("");
        Console.WriteLine($"Size is {list.Count}; Capacity is {list.Capacity}");
    }
}