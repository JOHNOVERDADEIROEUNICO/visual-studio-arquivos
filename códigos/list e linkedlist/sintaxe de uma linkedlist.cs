using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> nomes = new LinkedList<string>();
        nomes.AddLast("Ana");
        nomes.AddLast("Carlos");
        nomes.AddFirst("João");

        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

        nomes.Remove("Carlos");
        Console.WriteLine("Depois da remoção:");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}