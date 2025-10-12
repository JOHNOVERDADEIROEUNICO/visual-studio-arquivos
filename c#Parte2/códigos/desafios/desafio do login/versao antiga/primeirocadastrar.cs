using Estilo.Styles;

class Cadastrar
{
    private string Nome { get; set; } = string.Empty;

    private string Senha { get; set; } = string.Empty;

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
            else if (Senha.Contains(Senha.ToLower()) || Senha.Contains(Senha.ToUpper()))
            {
                Linha.Linha20();
                Console.WriteLine("A senha deve conter ao menos uma letra maiúscula e uma minúscula!");
                seq++;
                continue;
            }
            else if ((Senha.Contains("!") != true) && (Senha.Contains("@") != true) && (Senha.Contains("#") != true) && (Senha.Contains("$") != true) && (Senha.Contains("%") != true) && (Senha.Contains("^") != true) && (Senha.Contains("&") != true) && (Senha.Contains("*") != true) && (Senha.Contains("(") != true) && (Senha.Contains(")") != true))
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
    private string Nome { get; set; } = string.Empty;

    private string Senha { get; set; } = string.Empty;

    public List<string[]> Usuarios { get; private set; } = new List<string[]>();
    public string[] register = new string[2];

    public void NewLogin()
    {
        Nome = CriarNome();

        Senha = CriarSenha();

        register[0] = Nome;
        register[1] = Senha;

        Usuarios.Add((string[])register.Clone());

        Array.Clear(register);
        

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
