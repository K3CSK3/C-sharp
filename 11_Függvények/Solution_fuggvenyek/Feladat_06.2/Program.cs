using IOLibrary;

Dolgozat test = new Dolgozat();

Console.WriteLine("Please give me tha maximum amount of point on the test: ");
int maxPoints = ExtendedConsole.ReadInteger();

Console.WriteLine("Please type your name");
test.studentName = ExtendedConsole.ReadName();

do
{
    Console.WriteLine("Please give me the amount of points you got: ");
    test.aquiredPoints = ExtendedConsole.ReadInteger();
} while ( test.aquiredPoints < 0 || test.aquiredPoints > maxPoints);


test.grade = GradeCalculator(test.aquiredPoints, maxPoints);

test.percentage = ((double)test.aquiredPoints / maxPoints)*100;



Console.Clear();
Console.WriteLine($"Your test:\n\tStudents Name: {test.studentName}\n\tScored Points:{test.aquiredPoints}\n\tPercentage of test: {test.percentage}%\n\tGrade of test: {test.grade}");


int GradeCalculator(double aquiredPoints, int maxPoints)
{
    double percentage = (aquiredPoints / maxPoints)*100;
       
    switch (percentage)
    {
        case < 50 : return 1;
        case < 60 : return 2;
        case < 70 : return 3;
        case < 85 : return 4;
        default : return 5;
    }
}