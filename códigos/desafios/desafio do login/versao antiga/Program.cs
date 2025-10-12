// Cria um sistema de login com multiplos usuarios.
using Estilo.Styles;
class Program
{
    static void Main()
    {
        Login registrador = new Login();

        Linha.Linha30();
        Console.WriteLine(".SIMULANDO A CRIAÇÃO DE CONTAS DE ALGUM SITE.");
        Linha.Linha30();
        
        Linha.Linha30();
        Console.WriteLine("Escolha entre criar conta, mostrar usuários e apagar conta:\n[1] Criar conta.\n[2] Apagar conta.\n[3] Mostrar usuários.\n[4] Sair.");
        Linha.Linha20();
        while (true)
        {
            Console.Write("Sua opção: ");
            string opcao = NotNull.Tratador();

            if ((opcao.Contains("1") != true) && (opcao.Contains("2") != true) && (opcao.Contains("3") != true) && (opcao.Contains("4") != true))
            {
                Console.WriteLine("Você deve digitar uma das quatro opções.");
                continue;
            }

            Linha.Linha20();
            switch (opcao)
            {
                case "1":
                    registrador.NewLogin();
                    break;

                case "2":
                    registrador.Remover();
                    break;

                case "3":
                    registrador.MostrarTodosUsuarios();
                    break;

                default:
                    Console.WriteLine("Algo deu errado, tente novamente.");
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