class Program
{
        static void Main()
        {
              //Operador terneário é uma forma simplificada de if else, o seu símbolo é ?:, veja como ele funciona:
              int idade = 20;

              string status = idade >= 18 ? "Maior de idade" : "Menor de iadade";
              // Perceba que o ? abre e o valor antes do : representa true enquanto o após o : representa false.
              Console.WriteLine($"O jovem é: {status}");
              //Perceba como um código de maioridade é reduzido a poucas linhas.
        }
        
}