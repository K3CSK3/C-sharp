namespace Solution.Models;

public class Employee
{
    public string Name { get; set; }

    public string Project { get; set; }
    
    public ICollection<int> WeeklyWorkedHours { get; set; }

    public int SumOfWeeklyWorkedHours => WeeklyWorkedHours.Sum();

    public int WeeklySalary => SumOfWeeklyWorkedHours * 10000;

    public int MostWorkedHours => WeeklyWorkedHours.Max();

    public string MostWorkedHoursDay
    {
        get
        {
            List<Weekdays> weekdays = Enum.GetValues<Weekdays>().Cast<Weekdays>().ToList();

            int index = this.WeeklyWorkedHours.ToList().IndexOf(this.MostWorkedHours);

            return weekdays[index].ToString();
        }
    }

    public Rating Rating => this.SumOfWeeklyWorkedHours switch
    {
        >= 30 => Rating.Excellent,
        >= 21 => Rating.Average,
        _ => Rating.Bad
    };

    public Employee()
    { 
    }

    public Employee(string name, string project, ICollection<int> weeklyWorkedHours)
    {
        Name = name;
        Project = project;
        WeeklyWorkedHours = weeklyWorkedHours;
    }
}

/*
 public class Employee(string name, string project, ICollection<int> weeklyWorkedHours)
{
        public string Name { get; set; } = name;
        public string Project { get; set; } = project;
        public ICollection<int> WeeklyWorkedHours { get; set; } = weeklyWorkedHours;
 
}
*/