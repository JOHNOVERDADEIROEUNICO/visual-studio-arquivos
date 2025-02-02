var n1 = 15;
var n2 = 30.5;

Console.WriteLine(n1 + n2);

string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

string name = "Bob";
int widgetsSold2 = 7;

Console.WriteLine(name + " sold " + widgetsSold2 + 7 + " widgets.");

string nName = "Bob";
int widgetsSold3 = 7;
Console.WriteLine(nName + " sold " + (widgetsSold3 + 7) + " widgets.");


int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;

Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal quotient2 = (decimal)first / (decimal)second;

Console.WriteLine(quotient2);