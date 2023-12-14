using System.Text;

public class Worker
{
    private const int MONTHS = 12;

    public string Name { get; set; }

    public int[] Salaries { get; set; }

    public Worker()
    {
        Salaries = GetSalaries();
    }

    public Worker(string name): this()
    {
        this.Name = name;
    }

    public override string ToString()
    {
        /*string salaries = string.Join("  ", this.Salaries.Select(x => x.ToString()));
        return salaries;*/
        
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(this.Name.PadLeft(8));
        stringBuilder.Append($":  ");
        
        Console.WriteLine("\t\t JAN\t    FEB\t\tMAR\t    APR\t\tMAY\t    JUN\t\tJUL\t    AUG\t\tSEP\t    OCT\t\tNOV\t    DEC");
        foreach (var salary in this.Salaries)
        {
            stringBuilder.Append(salary.ToString().PadLeft(8)+" Ft ");
        }
        return stringBuilder.ToString();
    }

    public double SZJA 
    {
        get
        {
            return 0.335 * SalarySum();
        }
    }

    public double TB
    {
        get => SZJA * 0.45;
    }

    public double NyH => SZJA * 0.55;

    private int SalarySum() => this.Salaries.Sum(x => x);

    private int[] GetSalaries()
    {
        Random rnd = new Random();
        int[] salaries = new int[MONTHS];

        for (int i = 0; i < MONTHS; i++)
        {
            salaries[i] = rnd.Next(210000, 5000000);
        }

        return salaries;
    }
}
