//Matriz bidimensional
int[,] matriz = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matriz[i, j] = i + j;
    }
}

for (int i = 0; i <3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("["+ matriz[i,j]+ "]");
    }
    Console.WriteLine();
}
//Jogos 2D são um exemplo de uso de matrizes bidimensionais.