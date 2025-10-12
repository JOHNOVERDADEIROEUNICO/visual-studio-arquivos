//FUNC<T> FAZ PARTE DOS DELEGADOS PRÉ DEFINIDOS DA LINGUAGEM C#, QUE SÃO NADA MAIS NADA MENOS QUE FUNÇÕES QUE RECEBM PARAMETROS E RETORNA VALORES OU GERA SAÍDAS
Func<int, int> dobrar = x => x * 2;
Console.WriteLine(dobrar(5));  // Saída: 10
// PERCEBA QUE O ULTIMO TIPO É O TIPO DE VALOR QUE SERÁ RETORNADO
// OU SEJA FUNC<T> SERVE PARA FUNÇÕES QUE RETORNARÃO VALORES.

Func<int, int, int> somar = (a, b) => a + b;
Console.WriteLine(somar(3, 4));  // Saída: 7
// PERCEBA QUE PODEMOS TER MAIS DE UM VALOR DE ENTRADA, PORÉM O ULTIMO SEMPRE SERÁ O VALOR DE RETORNO.

Func<string> saudacao = () => "Olá!";
Console.WriteLine(saudacao());  // Saída: Olá!
// PERCEBA QUE QUANDO TEMOS SOMENTE UM TIPO DE VALOR SIGNIFICA QUE NÃO TEMOS PARÂMETROS DE ENTRADA, SOMENTE DE RETORNO.

//FUNC<T> COM CLASSE:
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

Func<Pessoa, string> apresentar = p => $"Nome: {p.Nome}, Idade: {p.Idade}";

var pessoa = new Pessoa { Nome = "Ana", Idade = 25 };
Console.WriteLine(apresentar(pessoa));  // Saída: Nome: Ana, Idade: 25
// PERCEBA QUE OS DELEGADOS FUNCIONAM COM QUALQUER TIPO.

//FUNC<T> COMO UM FILTRO:
List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa { Nome = "João", Idade = 17 },
    new Pessoa { Nome = "Maria", Idade = 22 }
};

var adultos = pessoas.Where(p => p.Idade >= 18);  // `p => p.Idade >= 18` é um Func<Pessoa, bool>

foreach (var p in adultos)
    Console.WriteLine(p.Nome);  // Saída: Maria
// ALÉM DO FUNC<T> TEMOS O PREDICATE<T> QUE É ESPECIFICO PARA RETORNOS BOOLEANOS.
