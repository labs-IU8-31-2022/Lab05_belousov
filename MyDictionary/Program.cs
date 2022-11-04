// See https://aka.ms/new-console-template for more information

using MyDictionary;

class Program
{
    static void Main(string[] args)
    {
        MyDictionary<string, int> dictionary = new MyDictionary<string,int>
            (new Item<string, int>("aaa", 123), new Item<string, int>("asdad", 321));
        Console.WriteLine($"Capacity is: {dictionary.Capacity} \nSize is: {dictionary.Count}");
        Console.WriteLine("============");
        foreach (var elem in dictionary)
        {
            Console.WriteLine(elem.ToString());
        }
        dictionary.Add("fff", 345);
        Console.WriteLine("============");
        Console.WriteLine(dictionary["fff"].ToString());
        Console.WriteLine($"Capacity is: {dictionary.Capacity} \nSize is: {dictionary.Count}");
    }
}