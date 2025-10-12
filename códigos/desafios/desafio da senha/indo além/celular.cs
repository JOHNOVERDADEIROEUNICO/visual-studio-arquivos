using System;
using System.Threading;
using Estilo.Styles;

class Celular 
{
    public string Marca { get; init; }
    public string Modelo { get; init; }
    public string Senha { get; private set; } =  string.Empty;
    public string SenhaAbrir { get; private set; } = string.Empty;
    private int N { get; set; }

    public Celular(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;

        Console.WriteLine($"Agora você possui o celular {Modelo} da marca {Marca}.");
    }

    public string CriarSenha(string password)
    {
        int seq = 0;

        Linha.Linha30();
        while (true)
        {
            if (seq > 0)
            {
                Console.Write("Digite novamente: ");
                password = NotNull.Tratador();
                Linha.Linha20();
            }

            if (password.Contains(" "))
            {
                Linha.Linha20();
                Console.WriteLine("A senha não deve conter espaços!");
                seq++;
                continue;
            }
            else if (password.Contains(password.ToLower()) || password.Contains(password.ToUpper()))
            {
                Linha.Linha20();
                Console.WriteLine("A senha deve conter ao menos uma letra maiúscula e uma minúscula!");
                seq++;
                continue;
            }
            else if (password.Length != 8)
            {
                Linha.Linha20();
                Console.WriteLine("A senha deve conter 8 exatos caracteres!");
                seq++;
                continue;
            }
            else if ((password.Contains("!") != true) && (password.Contains("@") != true) && (password.Contains("#") != true) && (password.Contains("$") != true) && (password.Contains("%") != true) && (password.Contains("^") != true) && (password.Contains("&") != true) && (password.Contains("*") != true) && (password.Contains("(") != true) && (password.Contains(")") != true))//O parentese é opcional, so nao tirei por preguiça.
            {
                Linha.Linha20();
                Console.WriteLine("A senha deve conter ao menos um caracter especial!");
                seq++;
                continue;
            }

            foreach (char letter in password)
            {
                if (int.TryParse(letter.ToString(), out var valor) == true)
                {
                    N++;
                }
            }

            if (N == 0)
            {
                Linha.Linha20();
                Console.WriteLine("A senha deve conter ao menos 1 número!");
                seq++;
                continue;
            }
            break;

        }
        Linha.Linha30();
        Console.WriteLine("Senha criada com sucesso!");
        return Senha = password;
    }

    public string Desbloquear(string password)
    {
        SenhaAbrir = password;
        int seq = 1;
        int segundos = 60;

        while (true)
        {

            if (SenhaAbrir == Senha)
            {
                Console.WriteLine("Tela desbloqueada com sucesso!");
                return SenhaAbrir;
            }
            else
            {
                if (seq == 3)
                {
                    Console.WriteLine("Você está errando muito! espere 1 minuto e tente novamente.");
                    seq = 0;
                    while (true)
                    {
                        Console.Write($"\rTempo restante: {segundos}");

                        Thread.Sleep(1000);

                        if (segundos == 0)
                        {
                            Console.WriteLine();
                            break;
                        }

                        segundos--;

                    }
                }

                seq++;

                Linha.Linha20();

                Console.WriteLine("Senha incorreta, Tente novamente.");
                Console.Write("Digite sua senha: ");
                SenhaAbrir = NotNull.Tratador();

                Linha.Linha20();

                continue;
            }
        }
    }
}
