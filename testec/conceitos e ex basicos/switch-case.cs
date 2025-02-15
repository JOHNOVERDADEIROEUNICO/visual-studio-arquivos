int employerLevel = 600;
string employeeName = "John";
string title = "";

switch (employerLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    case 500:
        title = "Director";
        break;
    default:
        title = "Unknown";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

// É possível usar dois cases para o mesmo valor:
/*
case 100:
case 200:
    title = "Senior Associate";
    break;
*/