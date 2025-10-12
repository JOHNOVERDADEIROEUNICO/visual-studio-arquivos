int numberEmployee = 25;
int totHoursMounth = 192;
decimal SalaryPerHour = 6.90m;

decimal minimumSalary = SalaryPerHour * totHoursMounth;
decimal totSalary = minimumSalary * numberEmployee;

Console.WriteLine($"The salary in a mounth will be {minimumSalary:c}\nthe total for {numberEmployee} employees will be {totSalary:c}");