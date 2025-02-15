string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad.", "I like all three of the menu choices" };

int position = 0;
int count = 0;

for (int myString = 0; myString < myStrings.Length; myString++)
{
    while(myStrings[myString] == myStrings[0])
    {
        position = myStrings[myString].IndexOf(".", position);

        Console.WriteLine(myStrings[myString].Substring(0, position).TrimStart());
        myStrings[myString] = myStrings[myString].Remove(0, position +1);

        position = 0;
        count++;

        if (count == 3)
        {
            break;
        }
    }

    if (myStrings[myString] == myStrings[1])
    {
        Console.WriteLine(myStrings[myString]);
    }
}