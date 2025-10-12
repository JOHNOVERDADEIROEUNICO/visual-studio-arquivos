using System;

class Program
{
    static void Main()
    {
        try
        {
            ProcessarDados();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro capturado no Main: {ex.Message}");
        }
    }

    static void ProcessarDados()
    {
        try
        {
            // Simulando um erro
            int resultado = Dividir(10, 0);
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Divisão por zero detectada.");
            
            // Relançando a mesma exceção (sem new)
            throw; // Mantém a stack trace original
        }
    }

    static int Dividir(int a, int b)
    {
        return a / b;
    }
}
