using System;

class Program
{
    static void Main()
    {
        Console.Write("Sisesta ridade arv: ");
        int ridadeArv = int.Parse(Console.ReadLine());

        for (int i = 1; i <= ridadeArv; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
