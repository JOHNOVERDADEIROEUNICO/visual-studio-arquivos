//Digite o level para se enquandrar em uma das condições;
int level = 19;
//Digite o tipo de permissão para se enquandrar em uma das condições;
string permission = "";

if (level > 55 && permission.Trim().ToUpper().Contains("ADMIN"))
{
    Console.WriteLine($"Welcome super {permission.Trim().ToUpper()} User.");
}
else if(level ==55 && permission.Trim().ToUpper().Contains("ADMIN"))
{
    Console.WriteLine($"Welcome {permission.Trim().ToUpper()} User.");
}
else if(level >= 20 && permission.Trim().ToUpper().Contains("GERENTE"))
{
    Console.WriteLine($"Welcome {permission.Trim().ToUpper()} User.");
    Console.WriteLine($"Contact Admin for acess.");
}
else if(level < 20 && permission.Trim().ToUpper().Contains("GERENTE"))
{
    Console.WriteLine($"Welcome {permission.Trim().ToUpper()}, You do not have permission to access this page.");
}
else if(!permission.Trim().ToUpper().Contains("GERENTE") || !permission.Trim().ToUpper().Contains("ADMIN"))
{
    Console.WriteLine($"You do not have permission to access this page.");
}