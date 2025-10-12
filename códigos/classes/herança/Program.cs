class Program
{
        static void Main()
        {
                Mamifero leao = new Mamifero("femea","leoa","amarelo", 0.110f, 120.0f);
                Mamifero2 elefante = new Mamifero2("macho", "elefante", "cinza", 4.0f, 600.0f);

                Console.WriteLine(leao.emitirSom());
                Console.WriteLine(leao.moder());
                Console.WriteLine(leao.estaGravida());

                Console.WriteLine(elefante.emitirSom());
                Console.WriteLine(elefante.moder());
                Console.WriteLine(elefante.estaGravida());

                Cachorro c = new Cachorro("femea", "branco", 0.90f, 25.0f);
                Console.WriteLine(c.emitirSom());
                Console.WriteLine(c.moder());
                Console.WriteLine(c.estaGravida());
        }
}