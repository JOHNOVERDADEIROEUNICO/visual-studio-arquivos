//DESAFIO CRIAR UM SISTEMA DE LOGIN COM USO DE BANCO DE DADOS PARA ARMAZENAR OS USUARIOS.

using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using ZstdSharp.Unsafe;
using Estilo.Styles;

class Program
{
    static void Main()
    {
        Conta gerenciarConta = new Conta();

        Linha.Linha30();
        Console.WriteLine("Simulando um sistema de cadastro e login com uso de banco de dados MySql");
        Console.WriteLine("Escolha uma opção:\n[1] Criar conta;\n[2] Logar;\n[3] Apagar conta;\n[4] Sair;");
        Linha.Linha30();

        while(true)
        {
            Console.Write("Sua opção: ");
            string opcao = NotNull.Tratador();

            if (!opcao.Any(ch => "12345".Contains(ch)))
            {
                Console.WriteLine("Você deve digitar uma das quatro opções.");
                continue;
            }

            Linha.Linha20();
            switch (opcao)
            {
                case "1":
                    gerenciarConta.CriarConta();
                    gerenciarConta.SalvarConta();
                    break;

                case "2":
                    gerenciarConta.AcessarConta();
                    break;

                case "3":
                    gerenciarConta.DeletarConta();
                    break;

            }
            Linha.Linha20();

            if (opcao.Contains("4"))
            {
                Console.WriteLine("Encerrando...");
                break;
            }
        
        }
        Linha.Linha30();

        
    }

    
}
