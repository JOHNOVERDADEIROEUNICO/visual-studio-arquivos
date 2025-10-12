using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        nomes.Add("Ana");
        nomes.Add("Carlos");
        nomes.Add("João");

        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

        nomes.Remove("Carlos");
        Console.WriteLine("Depois da remoção:");
        nomes.ForEach(n => Console.WriteLine(n));
    }
}