using System;

class Aula25
{
    static void Main()
    {
        int numRef = 50;
        DobraRef(ref numRef);
        Console.WriteLine(numRef);
        
        int num = 50;
        Dobra(num);
        Console.WriteLine(num);
    }

    static void DobraRef(ref int valor)
    {
        valor *= 2;
    }
    static void Dobra(int valor)
    {
        valor *= 2;
    }
}
