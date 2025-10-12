using System;
using System.Text.Json;

class Usuario
{
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }
    public bool Ativo { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}, Ativo: {Ativo}";
    }
}

class Program
{
    static void Main()
    {
        List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { Nome = "Ana", Idade = 25, Ativo = true },
            new Usuario { Nome = "Carlos", Idade = 40, Ativo = false }
        };

        string json = JsonSerializer.Serialize(usuarios);
        List<Usuario>? lista = JsonSerializer.Deserialize<List<Usuario>>(json);

        if (lista != null)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}