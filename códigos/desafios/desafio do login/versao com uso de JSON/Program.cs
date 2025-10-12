using System;
using System.Security.Cryptography; //NOME DA CLASSE NECESSÁRIA PARA USAR O SHA-256.
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using Estilo.Styles;

class Program
{
    static void Main()
    {
        Login User = new Login();
        Usuario Gerenciador = new Usuario();

        Linha.Linha30();
        Console.WriteLine(".SIMULANDO A CRIAÇÃO DE CONTAS DE ALGUM SITE.");
        Linha.Linha30();
        
        Linha.Linha30();
        Console.WriteLine("Escolha entre criar conta, mostrar usuários e apagar conta:\n[1] Criar conta.\n[2] Apagar conta.\n[3] Mostrar usuários.\n[4] Fazer login.\n[5] Sair");
        Linha.Linha20();
        while (true)
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
                    User.NewLogin();
                    break;

                case "2":
                    Gerenciador.Remover();
                    break;

                case "3":
                    Gerenciador.MostrarTodosUsuarios();
                    break;
                
                case "4":
                    Gerenciador.FazerLogin();
                    break;

            }
            Linha.Linha20();

            if (opcao.Contains("5"))
            {
                Console.WriteLine("Encerrando...");
                break;
            }
        }
        Linha.Linha30();
    }
}