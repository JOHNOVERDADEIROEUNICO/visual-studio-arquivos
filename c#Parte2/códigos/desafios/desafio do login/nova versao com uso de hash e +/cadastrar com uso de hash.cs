using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Estilo.Styles;

class Cadastrar
{
    private string Nome { get; set; } = string.Empty;

    private string Senha { get; set; } = string.Empty;

    private string HashSenha { get; set; } = string.Empty;

    public List<Cadastrar> Usuarios { get; private set; } = new List<Cadastrar>();

    private int N { get; set; }

    public override string ToString()
    {
        return $"{Nome}";
    }

    public string CriarSenha()
    {
        int seq = 0;
        Console.Write("Dgite sua senha: ");
        Senha = NotNull.Tratador();

        Linha.Linha30();
        while (true)
        {
            if (seq > 0)
            {
                Console.Write("Digite novamente: ");
                Senha = NotNull.Tratador();
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
        return Senha;
    }

    public string CriarNome()
    {
        Linha.Linha30();
        Console.WriteLine("Digite o seu novo nome.");
        Console.Write("Digite aqui: ");

        Nome = NotNull.Tratador();
        Linha.Linha30();

        Console.WriteLine("Novo nome criado com sucesso!");
        Linha.Linha30();

        return Nome;

    }

    public void NewLogin()
    {
        //PERECBA COMO FICOU MAIS SIMPLES AGORA:
        Cadastrar novo = new Cadastrar();
        
        novo.CriarNome();

        novo.CriarSenha();

        using(SHA256 sha256 = SHA256.Create())
        {
            byte[] bytesSenha = Encoding.UTF8.GetBytes(novo.Senha);

            byte[] hashSenhaByte = sha256.ComputeHash(bytesSenha);

            novo.HashSenha = BitConverter.ToString(hashSenhaByte).Replace("-", "").ToLower();
        }

        Usuarios.Add(novo);
    }

    public void Remover()
    {
        if (Usuarios.Count == 0)
        {
            Console.WriteLine("Não há usuários cadastrados.");
        }
        else
        {
            
            while (true)
            {
                Console.Write("Informe a sua senha para apagar sua conta: ");
                string password = NotNull.Tratador();

                Cadastrar? senha = Usuarios.Find(u => u.Senha == password);

                if(senha != null)
                {
                    Usuarios.Remove(senha);
                    Console.WriteLine("Sua conta foi apagada.");
                    break;
                }
                else
                {
                    Console.WriteLine("A senha está incorreta ou não existe. TENTE NOVAMENTE.");
                }
            }
        }
    }

    public void MostrarTodosUsuarios()
    {
        if (Usuarios.Count == 0)
        {
            Console.WriteLine("Não há usuários cadastrados.");
        }
        else
        {
            for (int i = 0; i < Usuarios.Count; i++)
            {
                Console.WriteLine(Usuarios[i]);
            }
        }
    }

    public void FazerLogin()
    {
        string passwordComparison;
        int seq = 1;
        int segundos = 60;

        if(Usuarios.Count == 0)
        {
            Console.WriteLine("Não há usuarios cadastrados.");
        }
        else
        {
            while (true)
            {
                Linha.Linha20();
                Console.Write("Digite seu nome: ");
                string name = NotNull.Tratador();

                Console.Write("Digite sua senha: ");
                string password = NotNull.Tratador();
                Linha.Linha20();

                using(SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytesSenha = Encoding.UTF8.GetBytes(password);

                    byte[] hashSenhaByte = sha256.ComputeHash(bytesSenha);

                    passwordComparison = BitConverter.ToString(hashSenhaByte).Replace("-", "").ToLower();
                }

                Cadastrar? passwordComparisonTrue = Usuarios.Find(n => n.HashSenha == passwordComparison);

                if (passwordComparisonTrue != null)
                {
                    Console.WriteLine("Login realizado com sucesso!");
                    break;
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
                    else
                    {
                        Console.WriteLine("Nome ou sehna estão errados, tente novamente.");
                    }

                    seq++;

                    continue;
                }
            }

        }
        
    }
}