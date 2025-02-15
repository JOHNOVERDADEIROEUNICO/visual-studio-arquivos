//Remova o comentário e veja a limitação do foreach

/*string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}*/

//Adicione o comentário para evitar o bug

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}
//Não mexa aqui
foreach (var name in names)
{
    Console.WriteLine(name);
}