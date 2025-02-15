for(int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for(int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine();

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}