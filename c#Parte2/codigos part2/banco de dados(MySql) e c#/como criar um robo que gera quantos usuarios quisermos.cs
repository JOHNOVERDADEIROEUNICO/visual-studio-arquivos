using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using ZstdSharp.Unsafe;

class Program
{
    static Random rnd = new Random();

    static void Main()
    {
        string conexao = "Server=localhost;Database=cadastrousuarioshash;User=root;Password=irineu@vocenaosabenemeu09;";

        using (MySqlConnection mysqlConn = new MySqlConnection(conexao))
        {
            mysqlConn.Open();

            for (int i = 0; i < 10; i++)//gerando até 10 usuarios aleatórios
            {
                string nome = "User" + rnd.Next(1000, 9999);//Depois gerar nomes mais realistas.
                string senha = GerarSenhaAleatoria(8);//ATÉ 8 CARACTERES.
                string senhaHash = GerarHash(senha);

                string mysqlCommand = "INSERT INTO users (nome, senha_hash) VALUES (@nome, @Hash)";

                using (MySqlCommand cmd = new MySqlCommand(mysqlCommand, mysqlConn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@hash", senhaHash);

                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Usuario criado com sucesso!");
            }
        }
    }

    //GERAR SENHA ALEATÓRIA:
    static string GerarSenhaAleatoria(int tamanho)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] newSenha = new char[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            newSenha[i] = chars[rnd.Next(chars.Length)];
        }
        return new string(newSenha);
    }

    //MÉTODO GERADOR DE HASH.
    static string GerarHash(string texto)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}