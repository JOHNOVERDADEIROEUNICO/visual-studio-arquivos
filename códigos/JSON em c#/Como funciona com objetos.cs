using System;
using System.Text.Json;

class Usuario
{
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }
    public bool Ativo { get; set; }
}

class Program
{
    static void Main()
    {
        // Criando um objeto
        Usuario user = new Usuario { Nome = "João", Idade = 30, Ativo = true };

        // 🔄 Serializar objeto para JSON
        string jsonString = JsonSerializer.Serialize(user);
        Console.WriteLine("JSON gerado:\n" + jsonString);

        // 🔁 Desserializar JSON de volta para objeto
        Usuario? novoUser = JsonSerializer.Deserialize<Usuario>(jsonString);
        
        if (novoUser != null)
            Console.WriteLine($"Nome: {novoUser.Nome}, Idade: {novoUser.Idade}, Ativo: {novoUser.Ativo}");

        // Gravar em arquivo
        File.WriteAllText(@"C:\Users\hugol_000\Desktop\vs code\projetos\projetos e arquivos\c# projetos\códigos\JSON em c#\usuario.json", jsonString);

        // Ler de arquivo
        string jsonLido = File.ReadAllText(@"C:\Users\hugol_000\Desktop\vs code\projetos\projetos e arquivos\c# projetos\códigos\JSON em c#\usuario.json");
        Usuario? usuarioLido = JsonSerializer.Deserialize<Usuario>(jsonLido);
        
        if (usuarioLido != null)
            Console.WriteLine($"Nome: {usuarioLido.Nome}, Idade: {usuarioLido.Idade}, Ativo: {usuarioLido.Ativo}");
    }
}
