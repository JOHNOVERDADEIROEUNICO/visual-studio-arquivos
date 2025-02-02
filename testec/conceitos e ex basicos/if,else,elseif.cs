Random dice = new();

int dado1 = dice.Next(1, 7);
int dado2 = dice.Next(1, 7);
int dado3 = dice.Next(1, 7);

int totDados = dado1 + dado2 + dado3;

Console.WriteLine("Você deve tirar ao menos 10 pontos para receber o preimio, caso não consiga, você sairá sem nada.");


if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3))
{
    if ((dado1 == dado2) && (dado2 == dado3))
    {
        Console.WriteLine("Você Conseguiu Rolar Três Dados Iguais! +6 Pontos Bônus");
        totDados += 6;
    }
    else
    {
    Console.WriteLine("Você Conseguiu Rolar Dois Dados Iguais! +2 Pontos Bônus");
    totDados += 2;
    }
}


Console.WriteLine($"O primeiro dado foi {dado1}, o segundo dado foi {dado2} e o terceiro dado foi {dado3} totalizando: {totDados}");


if (totDados >= 10 && totDados < 15)
{
    Console.WriteLine("Você ganhou meio bitcoin!");
}
else if(totDados >=15)
{
    Console.WriteLine("Você ganhou um bitcoin!");
}
else
{
    Console.WriteLine("You Lose! HAHAHAHAHAHA"); 
}