int heroi = 10;
int monstro = 10;
int ataque = 0;
Random dado = new();

while (heroi > 0 && monstro > 0)
{
    ataque = dado.Next(1, 7);
    monstro -= ataque;

    Console.WriteLine($"Herói tirou {ataque}! Monstro ficou com {monstro} de vida.\n");
    if (monstro <= 0)
    {
        break;
    }

    ataque = dado.Next(1, 7);
    heroi -= ataque;

    Console.WriteLine($"Monstro tirou {ataque}! Herói ficou com {heroi} de vida.\n");
    if (heroi <= 0)
    {
        break;
    }

}

Console.WriteLine(heroi > monstro ?"Herói venceu a batalha!":"Monstro venceu a batalha!");