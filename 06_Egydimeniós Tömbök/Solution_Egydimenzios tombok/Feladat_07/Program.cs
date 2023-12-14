using IOLibrary;

DailyExpense[] expenses = GetDailyExpenses();
Console.Clear();

Console.WriteLine("Weekly Expenses:");
WriteWeeklyExpenses(expenses);

int weeklyExpenseSum = expenses.Sum(dailyExpense => dailyExpense.Expense);
Console.WriteLine($"Total Expenses:{weeklyExpenseSum.ToString().PadLeft(8)}Ft");

DailyExpense leastExpensiveDay = GetLeastExpensiveDay(expenses);
Console.WriteLine($"Least Expensive day of the week: ");
Console.WriteLine(leastExpensiveDay+" Ft");

bool expenseWas10000 = expenses.Any(x => x.Expense == 10000);
Console.WriteLine($"{(expenseWas10000 ? "There was" : "There wasn't")} a day with 10.000 Ft of spending");

DailyExpense[] GetDailyExpenses()
{
    DailyExpense[] expenses = new DailyExpense[7];
    string[] weekdays = Enum.GetNames(typeof(Days));

    for (int i = 0; i < 7; i++)
    {
        string day = weekdays[i];

        Console.Write($"Please type the expense on {day}:");
        int expense = ExtendedConsole.ReadInteger();

        expenses[i] = new DailyExpense(Enum.Parse<Days>(day), expense);
    }

    return expenses;
}

void WriteWeeklyExpenses(DailyExpense[] expenses)
{
    foreach (var expense in expenses)
    {
        Console.WriteLine(expense+" Ft");
    }

}

DailyExpense GetLeastExpensiveDay(DailyExpense[] expenses)
{
    int leastExpensive = expenses.Min(dailyExpense => dailyExpense.Expense);
    DailyExpense leastExpensiveDay = expenses.First(dailyExpense => dailyExpense.Expense == leastExpensive);

    return leastExpensiveDay;
}