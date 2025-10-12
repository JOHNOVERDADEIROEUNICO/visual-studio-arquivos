using System;

class Program
{
    static void Main()
    {
        try
        {
            MetodoQuePodeLancarExcecao();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Stack trace COM perda de informação:");
            Console.WriteLine(ex.StackTrace);
        }
    }

    static void MetodoQuePodeLancarExcecao()
    {
        try
        {
            // Simulando um erro
            int zero = 0;
            int resultado = 10 / zero;
        }
        catch (Exception ex)
        {
            // Isso vai sobrescrever a stack trace original, basicamente ele não vai mostrar nada, só vai travar o progama.
            throw ex; // ← NÃO RECOMENDADO
        }
    }
}