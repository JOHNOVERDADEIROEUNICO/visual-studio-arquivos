using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando um dicionário
        Dictionary<string, string> agenda = new Dictionary<string, string>();
        // os tipos string e string são para definir (em ordem) o indentificador e o valor contido no indentificador, pode se usar qualquer tipo neste caso.

        // Adicionando itens (chave, valor)
        agenda["Maria"] = "1234-5678";
        agenda["João"] = "9876-5432";

        // Acessando um valor pela chave
        Console.WriteLine("Telefone da Maria: " + agenda["Maria"]);
    }
}
