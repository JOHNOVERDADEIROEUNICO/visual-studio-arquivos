for (int i = 1; i <= 15; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i}\t-FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i}\t-Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i}\t-Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}