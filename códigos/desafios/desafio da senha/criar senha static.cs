using Estilo.Styles;

class CriarSenha : Linha
{
    private string senha { get; set; }
    private int n { get; set; }

    public static string NewPassword(string password)
    {
        int seq = 0;

        Linha30();
        while (true)
        {
            if (seq > 0)
            {
                Console.Write("Digite novamente: ");
                password = Console.ReadLine();
                Linha20();
            }

            if (password.Contains(" "))
            {
                Linha20();
                Console.WriteLine("A senha não deve conter espaços!");
                seq++;
                continue;
            }
            else if (password.Contains(password.ToLower()) || password.Contains(password.ToUpper()))
            {
                Linha20();
                Console.WriteLine("A senha deve conter ao menos uma letra maiúscula e uma minúscula!");
                seq++;
                continue;
            }
            else if (password.Length != 8)
            {
                Linha20();
                Console.WriteLine("A senha deve conter 8 exatos caracteres!");
                seq++;
                continue;
            }
            else if ((password.Contains("!") != true) && (password.Contains("@") != true) && (password.Contains("#") != true) && (password.Contains("$") != true) && (password.Contains("%") != true) && (password.Contains("^") != true) && (password.Contains("&") != true) && (password.Contains("*") != true) && (password.Contains("(") != true) && (password.Contains(")") != true))//O parentese é opcional, so nao tirei por preguiça.
            {
                Linha20();
                Console.WriteLine("A senha deve conter ao menos um caracter especial!");
                seq++;
                continue;
            }

            foreach (char letter in password)
            {
                if (int.TryParse(letter.ToString(), out var valor) == true)
                {
                    n++;
                }
            }

            if (n == 0)
            {
                Linha20();
                Console.WriteLine("A senha deve conter ao menos 1 número!");
                seq++;
                continue;
            }
            break;

        }
        Linha30();

        senha = password;
    }
}