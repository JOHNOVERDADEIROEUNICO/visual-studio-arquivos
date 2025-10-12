using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            
            ValidarIdade(idade);
            
            Console.WriteLine($"Idade válida: {idade} anos");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, digite um número válido.");
        }
    }

    static void ValidarIdade(int idade)
    {
        if (idade < 0)
        {
            // Lançando uma nova exceção do tipo ArgumentException
            throw new ArgumentException("Idade não pode ser negativa.");
        }
        
        if (idade > 120)
        {
            throw new ArgumentException("Idade não pode ser maior que 120 anos.");
        }
    }
}