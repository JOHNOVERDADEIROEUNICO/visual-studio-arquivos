using Estilo.Styles;
using System;
using System.Linq;

class NotNull
{
    public static string Tratador()
    {
        string entrada;

        while (true)
        {

            entrada = (Console.ReadLine() ?? "").Trim();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Linha.Linha10();
                Console.WriteLine("Nenhum nome encontrado, por favor digite um nome.");
                Console.Write("Digite aqui: ");
            }
            else
            {
                return entrada;
            }
        }
    }
}

class Converter
{
    public static int Inteiro()
    {
        while (true)
        {
            string entrada = (Console.ReadLine() ?? "");

            string entradaSemEspaços = string.Concat(entrada.Where(c => !char.IsWhiteSpace(c)));

            if (int.TryParse(entradaSemEspaços, out int numero))
                return numero;
            else
                Console.WriteLine("Algo deu errado, tente novamente.");
        }
    }

    public static decimal Decimal()
    {
        while (true)
        {
            string entrada = (Console.ReadLine() ?? "");

            entrada = entrada.Replace(".", ",");

            string entradaSemEspaços = string.Concat(entrada.Where(c => !char.IsWhiteSpace(c)));

            if (decimal.TryParse(entradaSemEspaços, out decimal numero))
                return numero;
            else
                Console.WriteLine("Algo deu errado, tente novamente.");
        }
    }
}

class Calculadora
{
    private decimal? Total { get; set; } = 0;
    private int giros = 0;
    private decimal? valor {get; set;}
    private string simbolo {get; set;} = string.Empty;

    public void Executar()
    {
        while (true)
        {
            if (giros == 0)
            {
                Console.Write("Digite o valor: ");
                valor = Converter.Decimal();
                Total += valor;
                Console.WriteLine(Total);
            }

            while (true)
            {
                Console.Write("Digite o simbolo ([+] [-] [*] [/] [=]): ");
                simbolo = NotNull.Tratador();

                if (simbolo.Any(s => "+-*/=".Contains(s)))
                    break;
                else
                    Console.WriteLine("Algo deu errado. Digite o simbolo novamnete!");
            }

            if(simbolo != "=")
            {
                Console.Write("Digite o valor: ");
                valor = Converter.Decimal();
            }

            switch(simbolo)
            {
                case "+":
                    Total += valor;
                    break;
                case "-":
                    Total -= valor;
                    break;
                case "*":
                    Total *= valor;
                    break;
                case "/":
                    Total /= valor;
                    break;
            }

            if(simbolo == "=")
                break;
            else
            {
                giros ++;
                continue;
            }

        }

        Console.WriteLine($"O resultado foi: {Total}");
    }
}