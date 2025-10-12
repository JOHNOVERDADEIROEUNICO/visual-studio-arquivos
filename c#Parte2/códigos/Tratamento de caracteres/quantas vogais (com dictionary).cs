using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<char, int> vogais = new Dictionary<char, int>
        {
            { 'a', 0 },
            { 'e', 0 },
            { 'i', 0 },
            { 'o', 0 },
            { 'u', 0 }
        };

        Console.WriteLine("Digite uma frase para saber quantas vogais ela possui:");
        string frase = Console.ReadLine()?.Trim().ToLower() ?? "";

        foreach (char letra in frase)
        {
            if (vogais.ContainsKey(letra))
            {
                vogais[letra]++;
            }
        }

        int totalVogais = 0;
        Console.WriteLine("\nRESULTADO:");
        foreach (var item in vogais)
        {
            Console.WriteLine($"{char.ToUpper(item.Key)}: {item.Value}");
            totalVogais += item.Value;
        }

        Console.WriteLine($"TOTAL DE VOGAIS: {totalVogais}");
    }
}
