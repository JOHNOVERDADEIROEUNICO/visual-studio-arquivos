using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> idades = new List<int> { 15, 22, 17, 30, 12, 19 };

        // 1. Filtra quem tem 18 ou mais
        var maioresDeIdade = idades.Where(idade => idade >= 18);//SEU USO.

        // 2. Multiplica cada idade filtrada por 2
        var idadesDobro = maioresDeIdade.Select(idade => idade * 2);//SEU USO.

        // 3. Exibe os resultados
        Console.WriteLine("Idades filtradas e multiplicadas por 2:");
        foreach (var idade in idadesDobro)
        {
            Console.WriteLine(idade);
        }
    }
}
// PERCEBA QUE O OPERADOR LAMBDA É UM =>, SEGUNDO PERCEBA COMO ELE RESUME CÓDIGO, SEU USO É RECOMENDADO PARA PEQUENOS TRECHOS DE CÓDIGO EM FORMA DE ARGUMENTO PARA MÉTODOS, OPERAÇÕES COM COLEÇÕES ( ARRAYS, LISTAS, DICIONÁRIOS, ETC... ) E PRINCIPALMENTE, NAVERDADE OBRIGATORIO USO JUNTO COM OS MÉTODOS DO SYSTEM.LINQ. CONFIRA OUTROS EXEMPLOS BÁSICOS ABAIXO:

x => x * x
// ISTO É O MESMO QUE:
int Quadrado(int x) {
    return x * x;
}

//USO JUNTO DE UM FUNC<> OU ACTION<>:
Func<int, int> dobrar = x => x * 2;
Console.WriteLine(dobrar(5)); // Saída: 10

Action<string> mostrar = mensagem => Console.WriteLine(mensagem);
mostrar("Olá!");

//OUTRO EXEMPLO COM LINQ:
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

var pares = numeros.Where(n => n % 2 == 0);
// PERCEBA QUE CRIAMOS UM VERIFICADOR DE PAR ÍMPAR EM UMA LINHA.

//EXEMPLO COM MAIS DE UM PARÂMETRO:
(x, y) => x + y

//EXEMPLO COM BLOCO DE CÓDIGO:
x => {
    int resultado = x * 2;
    return resultado;
}
