using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Digite um número:");
            string input = Console.ReadLine();
            
            // Tentativa de converter a string para inteiro (pode lançar FormatException)
            int number = int.Parse(input);
            
            Console.WriteLine($"Número digitado: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: O valor digitado não é um número válido!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
        finally
        {
            // Este bloco é executado independentemente de ocorrer erro ou não
            Console.WriteLine("Operação concluída. Obrigado por usar o programa!");
        }
    }
}