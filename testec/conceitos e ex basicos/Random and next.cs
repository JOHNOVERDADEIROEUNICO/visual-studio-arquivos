Random dice = new();

int rolll = dice.Next(1, 7);

Console.WriteLine(rolll);

int roll2 = dice.Next();
int roll3 = dice.Next(101);
int roll4 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");