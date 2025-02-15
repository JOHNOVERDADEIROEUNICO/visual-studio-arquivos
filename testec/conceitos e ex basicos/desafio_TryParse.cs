int numericValue = 0;
bool validNumber = false;
bool isNumeric = false;

string? readResult;

Console.Write("Enter a integer between 5 and 10: ");
do
{
    readResult = Console.ReadLine();
    isNumeric = int.TryParse(readResult, out numericValue);

    if (isNumeric == true)
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            validNumber = true;
        }
        else
        {
            Console.Write("Invalid input. Please enter a integer between 5 and 10: ");
        }
    }
    else
    {
        Console.Write("Invalid input. Please enter a integer between 5 and 10: ");
    }

}while (validNumber == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted.");