using System;
using System.Collections.Generic;

// OBS RECOMENDO ESCOLHER UM DE CADA E TESTAR NO PROGAMA PRINCIPAL PARA EVITAR ERROS, TALVEZ O CÓDIGO TODO PODE BUGAR.
// Criando um dicionário
Dictionary<string, string> agenda = new Dictionary<string, string>();

// Adicionando itens (chave, valor)
agenda["Maria"] = "1234-5678";
agenda["João"] = "9876-5432";

// Acessando um valor pela chave
Console.WriteLine("Telefone da Maria: " + agenda["Maria"]);

// USANDO OUTROS TIPOS DE VALOR:
// INT:
Dictionary<string, int> notas = new Dictionary<string, int>();

        notas["Ana"] = 85;
        notas["Carlos"] = 92;

        Console.WriteLine("Nota de Ana: " + notas["Ana"]);

// FLOAT:
Dictionary<string, float> temperaturas = new Dictionary<string, float>();

        temperaturas["São Paulo"] = 23.5f;
        temperaturas["Curitiba"] = 18.2f;

        Console.WriteLine("Temperatura em Curitiba: " + temperaturas["Curitiba"] + "°C");

// BOOL:
Dictionary<string, bool> tarefas = new Dictionary<string, bool>();

        tarefas["Lavar roupa"] = true;
        tarefas["Estudar C#"] = false;

        Console.WriteLine("Estudar C# está concluído? " + tarefas["Estudar C#"]);

// COMO ALTERAR VALORES:
Dictionary<string, int> pontuacoes = new Dictionary<string, int>();
pontuacoes["João"] = 10;

// Atualizando o valor
pontuacoes["João"] = 20;

Console.WriteLine(pontuacoes["João"]); // Saída: 20

// COMO ALTERAR CHAVES:
Dictionary<string, int> estoque = new Dictionary<string, int>();
estoque["Banana"] = 50;

// Suponha que queremos mudar "Banana" para "Banana-Prata"
int valor = estoque["Banana"];
estoque.Remove("Banana");
estoque["Banana-Prata"] = valor;

// ARMAZENANDO UMA MATRIZ:
Dictionary<string, int[]> notasPorBimestre = new Dictionary<string, int[]>();

notasPorBimestre["Pedro"] = new int[] { 7, 8, 9, 10 };

Console.WriteLine(notasPorBimestre["Pedro"][2]); // Saída: 9

// ARMAZENANDO UMA LISTA:
Dictionary<string, List<string>> compras = new Dictionary<string, List<string>>();

compras["segunda"] = new List<string> { "pão", "leite", "café" };

Console.WriteLine(compras["segunda"][1]); // Saída: leite

// ARMAZENANDO OBJETOS DE UM CLASE:
class Pessoa
{
    public string Nome;
    public int Idade;
}

Dictionary<string, Pessoa> pessoas = new Dictionary<string, Pessoa>();

pessoas["cliente1"] = new Pessoa { Nome = "Ana", Idade = 30 };

Console.WriteLine(pessoas["cliente1"].Nome); // Saída: Ana

// COMBINANDO TIPOS:
Dictionary<string, List<Pessoa>> grupos = new Dictionary<string, List<Pessoa>>();
