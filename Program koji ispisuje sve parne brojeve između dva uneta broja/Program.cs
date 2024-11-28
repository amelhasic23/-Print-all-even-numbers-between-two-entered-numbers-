using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite prvi broj: ");
        int broj1 = int.Parse(Console.ReadLine());
        Console.Write("Unesite drugi broj: ");
        int broj2 = int.Parse(Console.ReadLine());

        // Provera koji broj je manji
        if (broj1 > broj2)
        {
            int temp = broj1;
            broj1 = broj2;
            broj2 = temp;
        }

        for (int broj = broj1; broj <= broj2; broj++)
        {
            if (broj % 2 == 0)
            {
                Console.Write(broj + " ");
            }
        }
    }
}
