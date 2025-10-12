using System;
using System.IO;

class Program
{
    static void Main()
    {
        string caminho = @"C:\Users\hugol_000\Desktop\vs code\projetos\projetos e arquivos\c# projetos\códigos\como criar um arquivo usando c#\meuarquivo.txt"; // Substitua pelo caminho desejado
        string conteudo = "Olá, este é o conteúdo do arquivo.";

        // Cria o arquivo e escreve o conteúdo
        File.WriteAllText(caminho, conteudo);

        Console.WriteLine("Arquivo criado com sucesso!");
        //SIM O ARQUIVO .txt ACIMA FOI CRIADO AQUI.
    }
}
