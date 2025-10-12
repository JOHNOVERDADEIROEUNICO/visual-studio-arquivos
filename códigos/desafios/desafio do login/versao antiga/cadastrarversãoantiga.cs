using System;
using System.Collections.Generic;
using System.Linq;
using Estilo.Styles;

class Cadastrar
{
    protected string Nome { get; set; } = string.Empty;

    protected string Senha { get; set; } = string.Empty;

    private int N { get; set; }

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

            //PERCEBA O USO DE ANY DO SYSRTEM.LINQ NESTA VERSÃO
            else if (!Senha.Any(char.IsUpper) || !Senha.Any(char.IsLower))
            {
                Linha.Linha20();
                Console.WriteLine("A senha deve conter ao menos uma letra maiúscula e uma minúscula!");
                seq++;
                continue;
            }

            //PERCEBA O USO DE ANY DO SYSTEM.LYNQ E O OPERADOR LAMBDA(=>) NESTA VERSÃO DEIXAO O CÓDIGO MENOR
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
}

class Login : Cadastrar
{
    //ESTAMOS BASICAMENTE CRIANDO UMA LISTA DO TIPO OBJETO DA CLASSE CADASTRAR
    public List<Cadastrar> Usuarios { get; private set; } = new List<Cadastrar>();

    public void NewLogin()
    {
        Nome = CriarNome();

        Senha = CriarSenha();
        
        //PERECBA COMO FICOU MAIS SIMPLES AGORA:
        Usuario novo = new Usuario { Nome = nome, Senha = senha };
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
                bool confirmation = false;
                Console.Write("Informe a sua senha para apagar sua conta: ");
                string password = NotNull.Tratador();

                for (int i = 0; i < Usuarios.Count; i++)
                {
                    if (password == Usuarios[i][1])
                    {
                        Usuarios.Remove(Usuarios[i]);
                        confirmation = true;
                    }
                }

                if (confirmation == true)
                {
                    Console.WriteLine("Sua conta foi apagada!");
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
                Console.WriteLine(Usuarios[i][0]);
            }
        }
    }
}