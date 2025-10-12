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

if (usuarios.Any(u => u.Nome == nomeProcurado)) // USO DE ANY IRÁ RETORNAR UM TUR/FALSE SE AQUELE NOME POR EXEMPLO ESTÁ ALI.
{
    Console.WriteLine("Usuário existe na lista.");
}

if (!Senha.Any(char.IsUpper) || !Senha.Any(char.IsLower)) // OUTRA POSSIBILIDADE É USAR O ANY COMO FORMA DE CONFERIR SE O TEXTO POSSUI CARACTERES MINÚSCULOS OU MAIÚSCULOS, AQUI NESTE CASO SE O TEXTO FOR INTEIRAMNETE MAIÚSCULO OU MINÚSCULO ELE RETORNA UM AVISO DIZENDO QUE O TEXTO DEVE CONTER AO MENOS UM CARACTER DE CADA.
{
    Linha.Linha20();
    Console.WriteLine("A senha deve conter ao menos uma letra maiúscula e uma minúscula!");
    seq++;
    continue;
}

if (!Senha.Any(ch => "!@#$%^&*()".Contains(ch))) // AQUI USAMOS O ANY PARA EVITAR TER DE ESCREVER UM CONTAINS PARA CADA CARACTERE ESPECIAL, OU SEJA ESTE CÓDIGO É O MESMO QUE ESCREVER UM CONTAINS PARA CADA CARACTER DESCRITO ACIMA.
{
    Linha.Linha20();
    Console.WriteLine("A senha deve conter ao menos um caracter especial!");
    seq++;
    continue;
}
