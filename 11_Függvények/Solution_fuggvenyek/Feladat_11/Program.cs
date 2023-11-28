using IOLibrary;

const int BASE_WORKING_HOUR = 40;

Console.WriteLine("Please type your name");
string workerName = ExtendedConsole.ReadString();

Console.WriteLine("Please type the hours you worked");
double workerWorkingHours = ExtendedConsole.ReadDouble();


double regularPayment = CalculatePayment(BASE_WORKING_HOUR);
double overtimePayment = workerWorkingHours > BASE_WORKING_HOUR ?
    CalculatePayment(workerWorkingHours - BASE_WORKING_HOUR) : 0;


double payment = regularPayment + overtimePayment;

Console.WriteLine($"{workerName}'s salary : {payment}");

double CalculatePayment(double workingHours, int wage = 1000) => workingHours * wage;