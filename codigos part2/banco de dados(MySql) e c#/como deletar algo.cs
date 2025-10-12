string conexao = "Server=localhost;Database=cadastrousuarioshash;User=root;Password=irineu@vocenaosabenemeu09;";

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

//O CÓDIGO COMPLETO ESTÁ NA CLASSE BANCODEDADOS, NA PASTA DE DESAFIOS, AQUI SOMENTE ESTÁ SENDO DEMONSTRADO, COMO FUNCIONARIA PARA DELETAR UM USUARIO.