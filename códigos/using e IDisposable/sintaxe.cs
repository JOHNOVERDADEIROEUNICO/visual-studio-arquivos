//ANTES DECIDI POR NÃO COLOCAR EXEMPLOS DA INTERFACE DO IDISPOSABLE DEVIDO AO FATO DE USING JÁ O IMPLEMENTAR AUTOMATICO, BASICAMENTE ESTÁ INTERFACE TEM O MÉTODO DE NOME DISPOSE() QUE TEM O OBEJTIVO DE INDICAR QUE O ELEMENTO PASSADO DEVE SER DESCARTADO APÓS O FIM DO PROGAMA OU O FIM DAQUELA LINHA, ISTO SE DEVE AO FATO DE EXISTEM ELEMENTOS EM C# QUE NÃO SÃO RECONHECIDOS PELO.NET, LOGO NÃO SÃO ENCERRADOS APÓS O FIM DO PROGAMA, POR ISSO ENTRA O DISPOSE() QUE INDICA AO C# QUE AQUELES ELEMENTOS DEVEM SER ENCERRADOS APÓS O FIM DO PROGAMA EVITANDO ASSIM QUE O CÓDIGO PESE, NORMAMELNTE ESSE ELEMENTOS SÃO OBJETOS QUE CONSOMEM RECURSOS COMO: ARQUIVOS, CONEXÕES STREAMS ETC...

//VAMOS AO USO DE USING(){} ENTÃO:
using (var recurso = new TipoQueImplementaIDisposable())
{
    // usar o recurso
}// recurso é automaticamente descartado aqui. O QUE OCORRE É QUE INTERNAMENTE TEM UM DISPOSE() QUE RECEBE O OBJETO DESCRITO NO PARÊNTESE DO USING E O DESCARTA DA MANEIRA CORRETA, OU SEJA APÓS SAIR DESTE ESCOPO ELE NÃO PODE SER MAIS USADO.

//AGORA VAMOS A EXEMPLOS DO USO NECESSÁRIO DESTE CARA:

//1º STREAM

//Aº READER:

//UM JEITO:
using (StreamReader leitor = new StreamReader("arquivo.txt"))
{
    string conteudo = leitor.ReadToEnd();
    Console.WriteLine(conteudo);
}
//OUTRO JEITO:
using System;
using System.IO;

class Exemplo1
{
    static void Main()
    {
        using (StreamReader leitor = new StreamReader("texto.txt"))
        {
            string linha = leitor.ReadLine();
            Console.WriteLine("Conteúdo da primeira linha: " + linha);
        } // leitor.Dispose() é chamado aqui automaticamente
    }
}

//Bº WRITE:

//UM JEITO:
using (StreamWriter escritor = new StreamWriter("log.txt", append: true))
{
    escritor.WriteLine("Log gravado em: " + DateTime.Now);
}

//OUTRO JEITO:
using System;
using System.IO;

class Exemplo2
{
    static void Main()
    {
        using (StreamWriter escritor = new StreamWriter("saida.txt"))
        {
            escritor.WriteLine("Olá, mundo!");
        } // escritor.Dispose() é chamado aqui automaticamente
    }
}

//2º CONEXÃO (EX: BANCO DE DADOS):

//UM JEITO:
using (SqlConnection conexao = new SqlConnection("sua-string-de-conexao"))
{
    conexao.Open();
    // comandos no banco de dados
}

//OUTRO JEITO:
using System;
using System.Data.SqlClient;

class Exemplo3
{
    static void Main()
    {
        string conexao = "Data Source=servidor;Initial Catalog=banco;Integrated Security=True";

        using (SqlConnection conn = new SqlConnection(conexao))
        {
            conn.Open();
            Console.WriteLine("Conexão aberta com sucesso!");
        } // conn.Dispose() garante que a conexão seja fechada
    }
}

//3º CRIAÇÃO DE ARQUIVO TEMPÓRARIO COM USO DA CLASSE FILESTREAM:
using (FileStream fs = File.Create("temp.bin"))
{
    byte[] dados = new byte[] { 0x0, 0x1, 0x2 };
    fs.Write(dados, 0, dados.Length);
}

//4º MÚLTIPLOS USING:
using System;
using System.IO;

class Exemplo4
{
    static void Main()
    {
        using (FileStream fs = new FileStream("teste.bin", FileMode.Create))
        using (BinaryWriter bw = new BinaryWriter(fs))
        {
            bw.Write(12345);
        } // Ambos fs.Dispose() e bw.Dispose() são chamados
    }
}

//5º CLASSE CUSTOMIZADA(USO DE IDISPOSABLE JUNTO):

//UM JEITO:
class Recurso : IDisposable
{
    public void Usar() => Console.WriteLine("Usando recurso...");
    public void Dispose() => Console.WriteLine("Liberando recurso...");
}

using (Recurso r = new Recurso())
{
    r.Usar();
}
//SAÍDA: Usando recurso...
       //Liberando recurso...

//OUTRO JEITO:
using System;

class Recurso : IDisposable
{
    public void Usar() => Console.WriteLine("Usando recurso...");
    
    public void Dispose() => Console.WriteLine("Recurso liberado.");
}

class Exemplo5
{
    static void Main()
    {
        using (Recurso r = new Recurso())
        {
            r.Usar();
        } // Chama automaticamente r.Dispose()
    }
}