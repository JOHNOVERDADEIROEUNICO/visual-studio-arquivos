List<string> nomes = new List<string> { "João", "Maria", "Pedro", "Ana" };

nomes.Select(n => { Console.WriteLine(n); return n; }).ToList(); // retorna o próprio elemento após o imprimir ou seja capaz de mostrar todos os elemntos de uma lista.
