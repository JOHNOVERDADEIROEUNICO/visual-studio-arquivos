class Program
{
        static void Main()
        {
                //VAMOS TRABALHAR COM TIPOS ANÚLAVEIS:
                int? numero = 10;

                if (numero.HasValue)
                {
                        Console.WriteLine($"temos o valor: {numero}");
                }
                else
                {
                        Console.WriteLine("Nenhum valor encontrado em numero.");
                }
                //OBS: O .HASVALUE NÃO FUNCIONA COM TIPOS NÃO NUMERICOS E BOOLEANOS, OU SEJA, STRING, ARRAYS ETC...
                //Evitando o InvalidOpereationException:
                // ele só ocorre quando tentamos usar valores nulos para casos em que precisamos de um valor existente

                Console.Write("Digite Ctrl + z para gerar um valor nulo, depois digite um número qualquer para ver a diferença: ");
                int? numero2 = Console.ReadLine();

                if(numero2 == null)
                {
                        Console.WriteLine("Opa um valor nulo ele não pode ser tratado!");
                }
                else
                {
                        if(numero.HasValue && numero2.HasValue)
                        {
                                Console.WriteLine($"O resultado da multiplicação de numero por numero2 é: {numero * numero2}");
                        }
                }
                //No fim apenas saiba que qualquer tipo que você for colocar como anulavel, so significa que ele pode conter um valor nulo, na grande maioria dos códigos ele não será utilizado, pois você precisará de valores concretos.
        }
        
}