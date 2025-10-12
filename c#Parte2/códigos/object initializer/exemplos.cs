//OBS: este código contém apenas demonstrações, ele está cheio de erros, logo não vai rodar em um console, considere pegar cada parte e testar separadamente em outro arquivo

//Modificando um objeto sem o object initializer:
var pessoa = new Pessoa();
pessoa.Nome = "Maria";
pessoa.Idade = 30;

//Modificando o objeto com o object initialiazer:
var pessoa = new Pessoa
{
    Nome = "Maria",
    Idade = 30
};

//object initializer e construtor juntos:
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

var pessoa = new Pessoa("Maria")
{
    Idade = 30
};

//object initializer com uma lista:
var lista = new List<string> { "Maria", "João", "Ana" };

var pessoas = new List<Pessoa>
{
    new Pessoa { Nome = "Maria", Idade = 30 },
    new Pessoa { Nome = "João", Idade = 25 }
};

//Exemplo final com object initializer, construtor e required:
public class Produto
{
    public required string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto()
    {
        Preco = 0m;
    }
}

var produto = new Produto
{
    Nome = "Caneta",
    Preco = 2.50m
};
