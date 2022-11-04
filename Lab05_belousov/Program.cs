// See https://aka.ms/new-console-template for more information

using Lab05_belousov;

class Program
{
    static void Main(string[] args)
    {
        MyMatrix m1 = new MyMatrix(2, 2, 4);
        m1.Show();
        m1.Fill();
        Console.Write("===\n");
        m1.Show();
        MyMatrix m2 = m1.ChangeSize(3,3);
        Console.Write("===\n");
        m2.Show();
        Console.Write("===\n");
        m2.ShowPartialy(2, 2);
    }
}