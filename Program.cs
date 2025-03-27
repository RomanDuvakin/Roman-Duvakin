using System;

class Program
{
    static void Main()
    {
        Console.Write("Sisesta arv: ");
        int arv = int.Parse(Console.ReadLine());

        if (arv > 0)
        {
            Console.WriteLine("Arv on positiivne.");
        }
        else if (arv < 0)
        {
            Console.WriteLine("Arv on negatiivne.");
        }
        else
        {
            Console.WriteLine("Arv on null.");
        }
    }
}