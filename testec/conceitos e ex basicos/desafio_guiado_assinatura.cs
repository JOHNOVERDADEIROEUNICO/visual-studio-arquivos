Random random = new();

int diasExpira = random.Next(12);
int porcentDoDisconto = 0;

if (diasExpira > 10)
{
    Console.WriteLine($"Ainda faltam {diasExpira} dias para vencer sua fatura.");
}
else if (diasExpira == 0)
{
    Console.WriteLine($"Sua fatura expirou.");
}
else if (diasExpira == 1)
{
    porcentDoDisconto = 20;

    Console.WriteLine($"Sua fatura vence hoje! Aproveite um desconto de {porcentDoDisconto}% e renove agora!");
}
else if (diasExpira > 1 && diasExpira <= 5)
{
    porcentDoDisconto = 10;

    Console.WriteLine($"Sua fatura vence em {diasExpira} dias! Aproveite um desconto de {porcentDoDisconto}% e renove agora!");
}
else if (diasExpira > 5 && diasExpira <= 10)
{
    Console.WriteLine($"Sua fatura vence em {diasExpira} dias, renove sua assinatura agora!");
}