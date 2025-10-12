using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using ZstdSharp.Unsafe;

class Program
{
    static void Main()
    {
        string conexao = "Server=localhost;Database=cadastrousuarioshash;User=root;Password=irineu@vocenaosabenemeu09;";

        Console.Write("Digite seu nome: ");
        string Nome = NotNull.Tratador();

        Console.Write("Digite sua senha: ");
        string Senha = NotNull.Tratador();

        //MÉTODO USADO LOGO ABAIXO.
        string Hash = GerarHashSha256(Senha);//OBS IMPORTANTE: QUANDO PASSAMOS O HASH NO FORMATO DE STRING, A VARIÁVEL DO BANCO DEVE SER DO TIPO CHAR DE TAMANHO 64, SE PASSARMOS O HASH NO SEU FORMATO BINÁRIO A VARIÁVEL DO BANCO DEVE SER DO TIPO BINARY DE TAMANHO 32. ALÉM DISSO A MANEIRA DE PASSAR O CÓDIGO NA PARTE DO CMD.PARAMETERS MUDA.

        using (MySqlConnection mysql = new MySqlConnection(conexao))
        {
            mysql.Open();

            string comandoInsert = "INSERT INTO users (nome, senha_hash) VALUES (@nome, @senha_hash)";
            using (MySqlCommand cmd = new MySqlCommand(comandoInsert, mysql))
            {
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@senha_hash", Hash);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    Console.WriteLine("Usuario adicionado com sucesso!");
                else
                    Console.WriteLine("Algo deu errado, nenhum dado adicionado.");
            }
        }



    }

    //FUNÇÃO PARA GERAR HASH
    static string GerarHashSha256(string senha)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);

            byte[] hashSenhaByte = sha.ComputeHash(bytesSenha);

            string newHash = BitConverter.ToString(hashSenhaByte).Replace("-", "").ToLower();

            return newHash;
        }
    }
    
}