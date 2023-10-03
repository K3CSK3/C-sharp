/*
-	Hapci.
-	Jó napot kedves Hapci. Miben segíthetek?
-	Engem érdekelne egy: Dodge SRT Hell Cat.
-	Értem, egy Dodge SRT Hell Cat. Hány köbcentis motorra gondolt?
-	5000
-	Kedves Hapci, a megvásárolni kívánt gépjármű ára 20.000.000 magyar forint. A vételárat hogyan kívánja rendezni: készpénz vagy hitel?
-	30% fizetném készpénzben a többit hitelre szeretném
-	Rendben, akkor 6 000 000 lesz a készpénz része és 14 000 000 + kamat lesz a hitel.
-	És mennyit tesz ki majd a kamat része?
-	1 120 000 forint lesz
-	Rendben
-	Milyen színben rendelhető?
-	Kérem szépen van:
-	1 – kék
-	2 – piros
-	3 – fekete
-	4 – citromsárga
-	5 – fehér
-	Piros színűt szeretnék. A feleségemnek lesz.
-	Rendben, akkor összegezzük:
*/
Console.Write("A vevő bemegy az autókereskedésbe és bemutatkozik.\n");
string name = Console.ReadLine();

Console.Write($"Jó napot kedves {name}. Miben segíthetek?\n");
Console.Write("Engem érdekelne egy:");
string interest = Console.ReadLine();

Console.Write($"Értem, egy {interest}. Hány köbcentis motorra gondolt?\n");
int cubicCentimetre = int.Parse(Console.ReadLine());

double price = 20000000;
Console.Write($"Kedves {name}, a megvásárolni kívánt gépjármű ára {price} magyar forint. A vételárat hogyan kívánja rendezni: készpénz vagy hitel?\n");

double percent = double.Parse(Console.ReadLine());
Console.Write("% fizetném készpénzben a többit hitelre szeretném.");
double paid = price * (percent / 100);
double loan = price - paid;


Console.Write($"Rendben, akkor {paid} lesz a készpénz része és {loan} + kamat lesz a hitel.\n");
Console.Write("És mennyit tesz ki majd a kamat része?\n");

double loanInterest;

if (loan < 5000000)
{
    loanInterest = loan * 0.05;
    Console.Write($"{loanInterest} forint lesz\n");
}

else if (loan >= 5000000 && loan < 10000000)
{
    loanInterest = loan * 0.08;
    Console.Write($"{loanInterest} forint lesz\n");
}

else
{ 
    loanInterest = loan * 0.13;
    Console.Write($"{loanInterest} forint lesz\n");
}

Console.Write("Rendben.\n");

Console.Write($"Kérem szépen van:\n\t1-kék\n\t2-piros\n\t3-fekete\n\t4-citromsárga\n\t5-fehér\n");
char choice = Console.ReadKey().KeyChar;

string color = choice switch 
{
    '1' => "Kék",
    '2' => "Piros",
    '3' => "Fekete",
    '4' => "Citromsárga",
    '5' => "Fehér"
};
Console.Write($"\n{color} színűt szeretnék. A feleségemnek lesz.");
Console.Write("Rendben, akkor összegezzük:");
Console.Write($"Megrendelő: {name}\n" +
    $"Jármű: {interest}\n" +
    $"Motor nagysága: {cubicCentimetre}ccm\n" +
    $"Szín: {color}\n" +
    $"Önerő: {paid} Huf\n" +
    $"Hitel: {loan} Huf\n" +
    $"Kamat: {loanInterest} Huf\n");