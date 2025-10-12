List<string> nomes = new List<string> { "João", "Maria", "Pedro", "Ana" };

nomes.Where(n => n != null).ToList().ForEach(n => Console.WriteLine(n)); // Where pode ser usado junto de um ForEach para acessar todos os elemntos de uma lista.

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

var pares = numeros.Where(n => n % 2 == 0).ToList();// Where pode ser usado para encontrar elemnetos especificos da lista, a exemplo este que encontra somente os pares.

Console.WriteLine("Números pares:");
foreach (var n in pares)
    Console.WriteLine(n);
