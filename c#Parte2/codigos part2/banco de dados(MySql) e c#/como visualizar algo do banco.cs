using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string conexao = "Server=localhost;Database=cadstrousuarios;User=root;Password=irineu@vocenaosabenemeu09;";

        using (MySqlConnection mysql = new MySqlConnection(conexao))
        {
            mysql.Open();

            string comandoSelect = "SELECT * FROM users";

            MySqlCommand cmd = new MySqlCommand(comandoSelect, mysql);
            MySqlDataReader leitura = cmd.ExecuteReader();//SE FOR USAR UM USING AO INVÉZ DE UM CLOSE IGUAL DESCRITO ABAIXO, ESTA LINHA PRECISARÁ ESTAR DENTRO DO PARÊNTESE DO USING.

            while (leitura.Read())
            {
                Console.WriteLine(leitura["nome"].ToString());//MANEIRA DE PASSAR SOMENTE UM PARAMETRO.
                Console.WriteLine("Nome: " + leitura["nome"] + "\nSenha: " + leitura["senha"]);//MANEIRA DE PASSAR MAIS DE UM PARAMETRO, PERCEBA QUE SE FAZ NECESSARIO O USO DE CONCATENAÇÃO DE CARACTERES.
            }

            leitura.Close();//PODE SE TAMBÉM USAR UM USING PARA FECHAR, MAS PREFERI USAR UM .CLOSE PARA FICAR MAIS SIMPLES.
        }
    }
}
