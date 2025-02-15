Random caraOuCoroa = new();

int result = caraOuCoroa.Next(1, 3);
string moeda = result == 1 ? "Cara" : "Coroa";
Console.WriteLine(moeda);