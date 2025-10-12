public class Pessoa
{
        public string Nome { get; set; }
}

class Program
{
        static void Main()
        {
                //Operador de condição nula (?.) serve para acessar um valor de um objeto se este não for nulo e se for lança null no console, sem lançar erro.
                Pessoa p = null;
                string nome = p?.Nome;

                Console.WriteLine($"O nome da pessoa é {nome}");

                Pessoa p2 = new Pessoa();
                p2.Nome = "Carlos";
                nome = p2?.Nome;

                Console.WriteLine($"O nome da pessoa é {nome}");


        }
        
}