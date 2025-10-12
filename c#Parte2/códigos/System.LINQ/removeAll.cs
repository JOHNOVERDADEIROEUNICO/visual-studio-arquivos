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

int removidos = usuarios.RemoveAll(u => u.Nome == nomeProcurado); // CASO QUEIRA REMOVER MAIS DE UM OBJETO COMO EXEMPLLO QUE TENHA ELEMENTOS IGUAIS O REMOVE ALL É PERFEITO.

if (removidos > 0)
{
    Console.WriteLine($"{removidos} usuário(s) removido(s).");
}
else
{
    Console.WriteLine("Nenhum usuário removido.");
}
