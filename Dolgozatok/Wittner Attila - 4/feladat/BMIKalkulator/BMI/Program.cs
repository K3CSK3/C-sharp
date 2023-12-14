string bmiIndex = string.Empty;

int weight = ExtendedConsole.ReadNumber("Please type your weight: ");

double height = ExtendedConsole.ReadDouble("Please type your height: ");

double bmi = ExtendedMath.CalculateBMI(weight, height); 

Console.WriteLine($"A {weight} kg és {height} m BMI értéke {bmi:F2}.");

switch (bmi)
{
    case <= 18.5:
        bmiIndex = "Thin";
        break;
    case <= 25:
        bmiIndex = "Average";
        break;
    case <= 30:
        bmiIndex = "Overweight";
        break;
    case > 30:
        bmiIndex = "Obese";
        break;
}

Console.WriteLine($"Based on your Body Mass Index you are {bmiIndex}!");