using System;
using System.Collections.Generic;

namespace ExemploUsuarios
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Sobrescrevendo o ToString() para personalizar a exibição
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    public class SistemaUsuarios
    {
        private List<Usuario> Usuarios;

        public SistemaUsuarios()
        {
            // Criando e adicionando alguns usuários
            Usuarios = new List<Usuario>
            {
                new Usuario { Nome = "João", Idade = 25 },
                new Usuario { Nome = "Maria", Idade = 30 },
                new Usuario { Nome = "Carlos", Idade = 22 }
            };
        }

        public void MostrarTodosUsuarios()
        {
            for (int i = 0; i < Usuarios.Count; i++)//UM FOREACH TAMBÉM FUNCIONA.
            {
                Console.WriteLine(Usuarios[i]); // Chama automaticamente ToString()
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SistemaUsuarios sistema = new SistemaUsuarios();
            sistema.MostrarTodosUsuarios();

            Console.ReadLine(); // Para manter o console aberto
        }
    }
}
