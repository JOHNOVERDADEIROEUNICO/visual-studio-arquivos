class Program
{
        static void Main()
        {
            //O operador de coalescência nula (??) serve para verificar se um valor é nulo, se este for, então ele substitiu este valor por um valor padrão para evitar erros.
            int? numero = null;

            int numero2 = numero ?? 10;
            Console.WriteLine($"O número é: {numero2}");
            //Também podemos usá_lo para evitar que o usuario cause erros no código, veja:
            Console.Write("Digite algo: ");
            string algo = (Console.ReadLine() ?? "");

            if(string.IsNullOrWhiteSpace(algo))
            {
                    Console.WriteLine("O usuário tentou dar uma de esperto e não digitar nada e bugar o sistema, mas eu sou mais!");
            }
            else
            {
                    Console.WriteLine($"Você digitou: {algo}");
            }
            // Bônus (??)= altera o valor se este for null:
            numero ??= 20;

            Console.WriteLine($"O numero é = {numero}"); 
        }
        
}
