//ACTION<T> FAZ PARTE DOS DELEGADOS PRÉ DEFINIDOS DA LINGUAGEM C#, QUE SÃO NADA MAIS NADA MENOS QUE FUNÇÕES QUE RECEBM PARAMETROS E RETORNA VALORES OU GERA SAÍDAS
Action<string> mostrar = nome => Console.WriteLine($"Olá, {nome}!");
mostrar("João");  // Saída: Olá, João!
// PERCEBA QUE O ACTION NÃO POSSUE RETORNO, OU SEJA ELE SERVE PARA FUNÇÕES DO TIPO VOID.

Action executar = () => Console.WriteLine("Executando...");
executar();  // Saída: Executando...

//ACTION<T> COM CLASSE:
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

Action<Pessoa> mostrar = p => Console.WriteLine($"{p.Nome} tem {p.Idade} anos.");

mostrar(new Pessoa { Nome = "Carlos", Idade = 30 });  // Saída: Carlos tem 30 anos.
// PERCEBA QUE OS DELEGADOS FUNCIONAM COM QUALQUER TIPO.