string? readResult;
bool validEntry = false;

Console.WriteLine("Enter a string containing at least three characteres:");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("The string must contain at least three characters. Try again:");
        }
    }


}while (validEntry == false);