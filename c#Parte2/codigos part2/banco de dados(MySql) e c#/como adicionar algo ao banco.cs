using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string conexao = "Server=localhost;Database=cadstrousuarios;User=root;Password=irineu@vocenaosabenemeu09;";

        Console.Write("Digite seu nome: ");
        string Nome = NotNull.Tratador();

        Console.Write("Digite sua senha: ");
        string Senha = NotNull.Tratador();

        using(MySqlConnection mysql = new MySqlConnection(conexao))
        {
            mysql.Open();

            string comandoInsert = "INSERT INTO users (nome, senha) VALUES (@nome, @senha)";

            using(MySqlCommand cmd = new MySqlCommand(comandoInsert, mysql))
            {
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@senha", Senha);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if(linhasAfetadas > 0)
                    Console.WriteLine("Usuario inserido com sucesso!");
                else
                    Console.WriteLine("Algo deu errado, nenhum usuario inserido.");
            }   

        }
        
    }
}