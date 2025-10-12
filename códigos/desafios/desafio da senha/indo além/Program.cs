class Program
{
        static void Main()
        {
                Console.Write("Digite qual a marca de celular que você deseja: ");
                string marca = NotNull.Tratador();
                

                Console.Write("Digite qual o modelo do celular: ");
                string modelo = NotNull.Tratador();

                Celular celular1 = new Celular(marca, modelo);

                Console.WriteLine("Digite uma senha seguindo as seguintes instruções: A senha deve ter exatamente 8 caracteres, a senha deve conter ao menos 1 caractere especial; numero; letra maiusucula e minuscula, não pode haver espaços.");

                Console.Write("Digite aqui: ");
                string senha = NotNull.Tratador();

                celular1.CriarSenha(senha);

                Console.Write("Digite sua senha para desbloquear a tela: ");
                senha = NotNull.Tratador();

                celular1.Desbloquear(senha);
        }
        
}
