using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using ZstdSharp.Unsafe;
using Estilo.Styles;

public class BancoDeDados
{
    private string conexao = "Server=localhost;Database=cadastrousuarioshash;User=root;Password=irineu@vocenaosabenemeu09;";
    private string Nome { get; set; } = string.Empty;
    private byte[]? Hash { get; set; }
    private bool confirmador;

    public void ReceberDados(string nome, byte[] hash)
    {
        Nome = nome;
        Hash = hash;
    }

    public void GuardarDados()
    {
        using (MySqlConnection mysql = new MySqlConnection(conexao))
        {
            mysql.Open();

            string comandoInsert = "INSERT INTO usersbinary (nome, senha_hash2) VALUES (@nome, @hash)";
            using (MySqlCommand cmd = new MySqlCommand(comandoInsert, mysql))
            {
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@hash", Hash);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    Console.WriteLine("Usuario adicionado com sucesso!");
                else
                    Console.WriteLine("Algo deu errado, nenhum dado adicionado.");
            }

        }
    }

    public void Logar(string nome, string senha)
    {
        byte[]? hashTeste;
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);

            byte[] hashSenhaByte = sha.ComputeHash(bytesSenha);

            hashTeste = hashSenhaByte;
        }

        using (MySqlConnection mysql = new MySqlConnection(conexao))
        {
            mysql.Open();

            string comandoSelectCount = "SELECT COUNT(*) FROM usersbinary WHERE nome = @nome AND senha_hash2 = @hash";
            using (MySqlCommand cmd = new MySqlCommand(comandoSelectCount, mysql))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@hash", hashTeste);

                int qtd = Convert.ToInt32(cmd.ExecuteScalar());

                if (qtd > 0)
                {
                    Console.WriteLine("Login realizado com sucesso!");
                    confirmador = true;
                }
                else
                    Console.WriteLine("Algo deu errado, Tente novamente.");
            }
        }

    }

    public void apagarConta(string senha)
    {
        byte[]? hashTeste;
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);

            byte[] hashSenhaByte = sha.ComputeHash(bytesSenha);

            hashTeste = hashSenhaByte;
        }

        using (MySqlConnection mysql = new MySqlConnection(conexao))
        {
            mysql.Open();

            string comandoDeleteWhere = "DELETE FROM usersbinary WHERE senha_hash2 = @hash";
            using (MySqlCommand cmd = new MySqlCommand(comandoDeleteWhere, mysql))
            {
                cmd.Parameters.AddWithValue("@hash", hashTeste);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    Console.WriteLine("Usuario deletado com sucesso!");
                else
                    Console.WriteLine("Algo deu errado, Tente novamente.");
            }
        }
    }

    public void ConfirmadorFalse()
    {
        confirmador = false;
    }

    public bool getConfirmador()
    {
        return confirmador;
    }
}

public class Usuario
{
    private string Nome { get; set; } = string.Empty;
    private string Senha { get; set; } = string.Empty;
    private byte[]? Hash { get; set; }
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

    public void GerarHash()
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytesSenha = Encoding.UTF8.GetBytes(Senha);

            byte[] hashSenhaByte = sha.ComputeHash(bytesSenha);

            Hash = hashSenhaByte;
        }
    }


    public byte[] getHash()
    {
        return Hash!;//A EXCLAMAÇÃO SIGNIFICA QUE EU ESTOU DIZENDO AO COMPILADOR QUE GARANTIDAMENTE O VALOR NUNCA SERÁ NULO.
    }

    public string getNome()
    {
        return Nome;
    }

}

public class Conta
{
    Usuario newUser = new Usuario();
    BancoDeDados gerenciador = new BancoDeDados();

    public void CriarConta()
    {
        newUser.CriarNome();
        newUser.CriarSenha();
        newUser.GerarHash();
    }

    public void SalvarConta()
    {
        gerenciador.ReceberDados(newUser.getNome(), newUser.getHash());
        gerenciador.GuardarDados();
    }

    public void AcessarConta()
    {
        while (true)
        {
            Console.Write("Digite seu nome: ");
            string nameLogin = NotNull.Tratador();

            Console.Write("Digite sua senha: ");
            string senhaLogin = NotNull.Tratador();

            gerenciador.Logar(nameLogin, senhaLogin);
            if (gerenciador.getConfirmador() == true)
                break;
        }
        gerenciador.ConfirmadorFalse();
    }

    public void DeletarConta()
    {
        Console.Write("Digite sua senha para apagar sua conta: ");
        string senhaDelete = NotNull.Tratador();

        gerenciador.apagarConta(senhaDelete);
    }


}