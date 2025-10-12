string naoENulo;

Console.Write("Digite algo: ");
naoENulo = (Console.ReadLine() ?? "");
// Desta forma se o usuario digitar um nulo, automaticamnte o compilador trocara o valor nulo por um espaço de caractere, usando um loop podemos obrigar o usuario a digitar algo de fato.
if(string.IsNullOrWhiteSpace(naoENulo))
{
    while(true)
    {
        Console.Write("Eu disse pra digitar algo: ");
        naoENulo = (Console.ReadLine() ?? "").Trim();

        if(string.IsNullOrWhiteSpace(naoENulo))
        {
            continue;
        }
        else
        {
            break;
        }
    }
}
Console.WriteLine($"Você digitou: {naoENulo}");