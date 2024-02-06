using IOLibrary;

int length = ExtendedConsole.ReadInteger("Adja meg az osztalyok szamat: ", 0, int.MaxValue);

GatheredCans[] cans = GetAmount(length);
Console.Clear();

GatheredCans[] decreasingOrder = OrderDescending(cans);
Console.WriteLine("Osztaly\t 0,25 dobozok\t 0,33 dobozok\t 0,5 dobozok\tPontok");
WriteToConsole(decreasingOrder);


int canAmount = cans.Sum(x => x.QuarterLiter + x.ThirdLiter + x.HalfLiter);
Console.WriteLine($"\nA reszt vett osztalyok osszesen {canAmount} gyujtottek ossze.");


double average = cans.Average(x => x.Points);
Console.WriteLine($"\nA reszt vett osztalyok pontjainak az atlaga: {average}.");


int aboveAverage = cans.Count(x => x.Points > average);
Console.WriteLine($"\nA pontok alapjan {aboveAverage} osztaly teljesitett az atlag felett");


string canType = GetMostGatheredCan(cans);
Console.WriteLine($"\nA legtobb a {canType} dobozbol gyult ossze.");

int bestClass = cans.Max(x => x.Points);
int worstClass = cans.Min(x => x.Points);
int difference = bestClass - worstClass;
Console.WriteLine($"\nA legtobb es a legkevesebb pontot gyujto osztaly kozt {difference} pontkulonbseg van.");

bool exactly100Points = cans.Any(x => x.Points == 100);
Console.WriteLine($"\n{(exactly100Points ? "Van" : "Nincs")} olyan osztály, amely pontosan 100 pontot ért el.");

string GetMostGatheredCan(GatheredCans[] cans){
    int mostQuarterCans = cans.Max(x => x.QuarterLiter);
    int mostThirdCans = cans.Max(x => x.ThirdLiter);
    int mostHalfCans = cans.Max(x => x.HalfLiter);

    if (mostQuarterCans > mostThirdCans && mostQuarterCans > mostHalfCans)
    {
        return "0.25l";
    }
    else if (mostThirdCans > mostQuarterCans && mostThirdCans > mostHalfCans)
    {
        return "0.33l";
    }
    else if (mostHalfCans > mostThirdCans && mostHalfCans > mostQuarterCans)
    {
        return "0.5l";
    }
    return "semmilyen";
}


GatheredCans[] OrderDescending(GatheredCans[] cans)
{
    GatheredCans temp;
    for (int i = 0; i < cans.Length; i++)
    {
        for (int j = 0; j < cans.Length; j++)
        {
            if (cans[i].Points > cans[j].Points)
            {
                temp = cans[j];
                cans[j] = cans[i];
                cans[i] = temp;
            }
        }
    }
    return cans;
}

void WriteToConsole(GatheredCans[] cans)
{
    foreach (GatheredCans can in cans)
    {
        Console.WriteLine($"{can}");
    }
}


GatheredCans[] GetAmount(int length){
    GatheredCans[] cans = new GatheredCans[length];
    for(int i = 0; i < length; i++)
    {
        string className = ExtendedConsole.ReadString("Adja meg az osztaly nevet: ");
        int quarterLiter = ExtendedConsole.ReadInteger("Adja meg az osztaly mennyi 0.25l-es dobozt gyujtott: ", 0, int.MaxValue);
        int thirdLiter = ExtendedConsole.ReadInteger("Adja meg az osztaly mennyi 0.33l-es dobozt gyujtott: ", 0, int.MaxValue);
        int halfLiter = ExtendedConsole.ReadInteger("Adja meg az osztaly mennyi 0.5l-es dobozt gyujtott: ", 0, int.MaxValue);

        cans[i] = new GatheredCans(className, quarterLiter, thirdLiter, halfLiter);
    }
    return cans;
}