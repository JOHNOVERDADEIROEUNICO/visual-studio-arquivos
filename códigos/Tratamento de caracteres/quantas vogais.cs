int totA = 0;
int totE = 0;
int totI = 0;
int totO = 0;
int totU= 0;
int totVogal = 0;

Console.WriteLine("Digite uma frase para saber quantas vogais temos nela:");
string frase = Console.ReadLine().Trim().ToLower();

foreach(char name in frase)
{
    switch(name)
    {
        case 'a':
            totA ++;
            totVogal ++;
            break;
        case 'e':
            totE ++;
            totVogal ++;
            break;
        case 'i':
            totI ++;
            totVogal ++;
            break;
        case 'o':
            totO ++;
            totVogal ++;
            break;
        case 'u':
            totU ++;
            totVogal ++;
            break;
    }
}

Console.WriteLine($"RESULTADO:\nA: {totA}\nE: {totE}\nI: {totI}\nO: {totO}\nU: {totU}\nTOTAL DE VOGAIS: {totVogal}");