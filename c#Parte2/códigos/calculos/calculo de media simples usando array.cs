using System;
using System.Linq;


int[] tenNumeros = new int[10];


Console.WriteLine("Digite 10 números de sua preferencia para saber a média, o maior e o menor valor.");
for(int n = 0; n < 10; n++)
{
        Console.WriteLine($"digite o {n + 1}º número:");
        string nFake = Console.ReadLine();

        tenNumeros[n] = int.Parse(nFake);

        //if((maior == 0) && (menor == 0))
        //{
                //maior = tenNumeros[n];
                //menor = tenNumeros[n];
        //}
        //else if(maior < tenNumeros[n])
        //{
                //maior = tenNumeros[n];
        //}
        //else if(menor > tenNumeros[n])
        //{
                //menor = tenNumeros[n];
        //}
}

int maior = tenNumeros.Max();
int menor = tenNumeros.Min();
double media = tenNumeros.Sum() / 10.0;
Console.WriteLine($"O maior número digitado foi: {maior}\nO menor número digitado foi: {menor}\nA média de todos os números digitado é: {media:F2}");