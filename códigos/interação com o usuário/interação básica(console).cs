Console.WriteLine($"Qual o seu nome?");
string name = Console.ReadLine();

// tentei fazer com que ele leia na mesma linha do write line, deu certo, mas saiu tudo bugado kk
//string name = "";
//Console.WriteLine($"Qual o seu nome: {name = Console.ReadLine()}");

Console.WriteLine($"Seu nome é {name}");

Console.WriteLine($"Informe um número:");
string nfake = Console.ReadLine();

int n = int.Parse(nfake);

Console.WriteLine($"A raíz quadrada de {n} é igual a {Math.Round(Math.Pow(n,0.5), 4)}");