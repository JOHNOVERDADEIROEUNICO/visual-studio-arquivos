using System;
using System.Collections.Generic;
using System.Linq;

public class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }

    public Usuario(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }
}

List<Usuario> usuarios = new List<Usuario>
{
    new Usuario("Ana", "ana@email.com"),
    new Usuario("Carlos", "carlos@email.com"),
    new Usuario("João", "joao@email.com")
};

string nomeProcurado = "João";

Usuario encontrado = usuarios.Find(u => u.Nome == nomeProcurado); // USO DE FIND PARA ENCONTRAR UM OBJETO POR EXEMPLO ATRAVEZ DE UM ELEMENTO INTERNO.

if (encontrado != null)
{
    Console.WriteLine($"Usuário encontrado: {encontrado.Nome}, {encontrado.Email}");
}
else
{
    Console.WriteLine("Usuário não encontrado.");
}


