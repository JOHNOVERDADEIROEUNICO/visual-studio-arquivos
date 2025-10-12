using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

        var pares = numeros.Where(n => n % 2 == 0).ToList();//A BIBLIOTECA É USADA AQUI

        Console.WriteLine("Números pares:");
        foreach (var n in pares)
            Console.WriteLine(n);
    }
}
//ALÉM DO .WHERE() TEM VARIOS OUTROS COMANDOS, LEMBRANDO QUE O SYSTEM.LINQ TRAZ OS COMANDOS SQL PARA DENTRO DO C# PERMITINDO QUE ESTES COMANDOS POSSAM SER USADOS PARA COLEÇÕES DE MEMÓRIA ( ARRAYS, LISTAS, DICIONÁRIOS, ETC... ).