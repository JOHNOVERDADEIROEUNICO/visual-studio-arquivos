// PARA ADICIONAR SOMENTE OS ELEMENTOS USA SE ADDRANGE, FUNCIONAL PARA MATRIZES DE UMA DIMENSÃO:
int[] matriz = { 1, 2, 3, 4, 5 };
List<int> lista = new List<int>();

lista.AddRange(matriz);

// PARA MATRIZES MULTIDIMENSIONAIS JÁ SE FAZ NECESSARIO UM FOR OU FOREACH:
int[,] matriz = { { 1, 2 }, { 3, 4 } };
List<int> lista = new List<int>();

foreach (int elemento in matriz)
{
    lista.Add(elemento);
}

// ISTO NÃO FUNCIONA PARA ADICIONAR SOMENTE OS ELEMENTOS:
List<int> lista = new List<int>();
lista.Add(matriz);  // ERRO: Não é possível adicionar um array inteiro como se fosse um único elemento

// PARA GUARDAR UMA MATRIZ INTEIRA DENTRO DE UM INDICE DA LISTA:
List<int[,]> listaDeMatrizes = new List<int[,]>();

int[,] matriz1 = new int[,] { { 1, 2 }, { 3, 4 } };
int[,] matriz2 = new int[,] { { 5, 6 }, { 7, 8 } };

listaDeMatrizes.Add(matriz1);
listaDeMatrizes.Add(matriz2); // NESTE CASO FUNCIONA PARA GUARDAR A MATRIZ INTEIRA EM UM INDICE.

// PARA ACESSAR UM VALOR ESPECIFICO DENTRO DESTAS MATRIZES:
Console.WriteLine(listaDeMatrizes[0][0, 1]);  // Exemplo: vai mostrar o número 2
// TAMBÉM FUNCIONA PARA MATRIZES UNIDIMENSIONAIS DO MESMO JEITO.

// SE USARMOS O .CLEAR EM UM ARRAY, O ARRAY VAI SER APAGADO MESMO QUE ESTEJA EM UMA LISTA, PARA RESOLVER ISTO USAMOS O MÉTODO .CLONE QUE CRIAR UMA CÓPIA DESTE ARRAY DENTOR DA LISTA, ASSIM EVITANDO O RISCO:
int[] array = { 1, 2, 3 };
List<int[]> lista = new List<int[]>();

lista.Add((int[])array.Clone());  // Faz uma cópia real dos dados

Array.Clear(array, 0, array.Length);

Console.WriteLine(lista[0][0]);  // Agora vai mostrar 1, porque a lista tem uma cópia independente
// SE PASSARMOS O .CLEAR SOMENTE COM O NOME DO ARRAY DENTRO DO CLEAR ELE APOAGA TUDO.
