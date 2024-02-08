using System;
using System.Collections.Generic;
using System.Text;

public class ActionDirectorAndWhen
{
    public string Name { get; set; }
    public List<DateTime> Times { get; set; }

    public ActionDirectorAndWhen()
    {
    }

    public ActionDirectorAndWhen(string name, List<DateTime> times)
    {
        this.Name = name;
        this.Times = times;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Name);
        foreach (var date in Times)
        {
            sb.AppendLine($"\t-{date:yyyy-MM-dd}");
        }
        return sb.ToString();
    }

}
