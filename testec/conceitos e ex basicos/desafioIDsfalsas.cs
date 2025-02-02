// Quebra improvisada para na hora do terminal nao ficar tudo junto.
Console.WriteLine();

string[] iD = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (var fraudulentID in iD)
{
   if (fraudulentID.StartsWith("B"))
   {
      Console.WriteLine($"This ID:{fraudulentID} is fraudulent!\n"); 
   }
}
// EASY.