int[,,] matriz3D = new int[3, 3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            matriz3D[i, j, k] += 1;
        }
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            Console.WriteLine("[" + matriz3D[i, j, k] + "]");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
//Compare com as bidemensionais e veja que ela nao forma um quadrado, ela deve formar um cubo, mas por agora ela é apenas uma matriz de 3x3x3.

//Jogos 3D são um exemplo de uso de matrizes tridimensionais.