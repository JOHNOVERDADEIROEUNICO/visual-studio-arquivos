// Testar para ver se funciona.
using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Estilo.Styles;

class Usuario
{
    private string Nome { get; set; } = string.Empty;

    private string Senha { get; set; } = string.Empty;

    public CriarNome(string newName)
    {
        Nome = newName;
    }

    public CriarSenha(string newSenha)
    {
        Senha = newSenha;
    }

    public MostrarNome()
    {
        return Nome;
    }

    public MostrarSenha()
    {
        return Senha;
    }
}

class Cadastrar
{
    protected string HashSenha { get; set; } = string.Empty;

    public static List<Cadastrar> Usuarios { get; private set; } = new List<Cadastrar>();

    private int N { get; set; }

    public override string ToString()
    {
        return $"{Nome}";
    }

    public CriarSenha()
    {
        int seq = 0;
        Console.Write("Dgite sua senha: ");
        string SenhaC = NotNull.Tratador();

        Linha.Linha30();
        while (true)
        {
            if (seq > 0)
            {
                Console.Write("Digite novamente: ");
                SenhaC = NotNull.Tratador();
                Linha.Linha20();
            }

            if (Senha.Contains(" "))
            {
                Linha.Linha20();
                Console.WriteLine("A senha não deve conter espaços!");
                seq++;
                continue;
            }
            else if (!Senha.Any(char.IsUpper) || !Senha.Any(char.IsLower))
            {
                Linha.Linha20();
                Console.WriteLine("A senha deve conter ao menos uma letra maiúscula e uma minúscula!");
                seq++;
                continue;
            }
            else if (!Senha.Any(ch => "!@#$%^&*()".Contains(ch)))
            {
                Linha.Linha20();
                Console.WriteLine("A senha deve conter ao menos um caracter especial!");
                seq++;
                continue;
            }

            foreach (char letter in Senha)
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
        Usuario.CriarSenha(SenhaC);
    }
}