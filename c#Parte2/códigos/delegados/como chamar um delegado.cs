//AQUI HÁ DEMONSTRAÇÕES DE COMO CHAMAR O(S) MÉTODO(S) DE UM DELEGADO
using System;

public delegate void MeuDelegado();

class Program
{
    static void Metodo1() => Console.WriteLine("Método 1 chamado");
    static void Metodo2() => Console.WriteLine("Método 2 chamado");

    static void Main()
    {
        MeuDelegado del = Metodo1;
        del += Metodo2;

        // 1. Invocação direta
        del();

        // 2. Usando .Invoke()
        del.Invoke();

        // 3. Usando operador de invocação segura
        MeuDelegado delNulo = null;
        delNulo?.Invoke();  // Não faz nada, pois é null

        // 4. Passando como argumento
        ExecutarDelegado(del);
    }

    static void ExecutarDelegado(MeuDelegado d)
    {
        d?.Invoke(); // Executa todos os métodos associados
    }
}
