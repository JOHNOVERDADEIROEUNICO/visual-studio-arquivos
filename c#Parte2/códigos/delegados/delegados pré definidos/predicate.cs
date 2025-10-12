//PREDICATE<T> FAZ PARTE DOS DELEGADOS PRÉ DEFINIDOS DA LINGUAGEM C#, QUE SÃO NADA MAIS NADA MENOS QUE FUNÇÕES QUE RECEBM PARAMETROS E RETORNA VALORES OU GERA SAÍDAS
Predicate<int> ehPar = numero => numero % 2 == 0;
Console.WriteLine(ehPar(4)); // Saída: True
// PERCEBA QUE O PREDICATE<T> SEMPRE RETORNA UM VALOR BOOL, OU SEJA SEU VALOR DE RETORNO É PRÉ DEFINIDO.

Predicate<int> ehMaiorQue10 = numero => numero > 10;

Console.WriteLine(ehMaiorQue10(5));   // False
Console.WriteLine(ehMaiorQue10(15));  // True

//EXEMPLO COM UM LIST<T>:
List<string> nomes = new List<string> { "Ana", "Carlos", "Bruno", "Amanda" };

string comA = nomes.Find(nome => nome.StartsWith("A"));

Console.WriteLine(comA);  // Saída: Ana

// PERCEBA QUE OS NOMES QUE POSSUEM A RECEBEM UM TRUE E A VARIAVEL RECEBE AQUELE NOME, ALÉM DISTO PERCEBA QUE O LISTA.FIND (MÉTODO DA CLASSE LISTA), POSSUI UM PREDICATE<T> DENTRO DELE VALIDANDO AS CONDIÇÕES.
// O MESMO OCORRE COM OUTROS MÉTODOS DE LIST<T> VEJA:

List<string> nomesComA = nomes.FindAll(nome => nome.StartsWith("A"));

foreach (var nome in nomesComA)
    Console.WriteLine(nome);  // Saída: Ana, Amanda
// TAMBÉM POSSUÍ UM PREDICATE<T> EMBUTIDO.

nomes.RemoveAll(nome => nome.StartsWith("A"));  // Remove Ana e Amanda
// TAMBÉM POSSUÍ UM PREDICATE<T> EMBUTIDO.