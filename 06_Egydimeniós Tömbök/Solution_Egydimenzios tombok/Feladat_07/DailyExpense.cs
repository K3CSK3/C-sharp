public class DailyExpense
{
    public Days Day { get; set;}
    
    public int Expense { get; set; }

    public DailyExpense()
    {

    }

    public DailyExpense(Days Day, int expese)
    {
        this.Day = Day;
        this.Expense = expese;
    }

    public override string ToString()
    {
        return $"{this.Day.ToString().PadLeft(9)} =>  {this.Expense.ToString().PadLeft(9)}";
    }
}
