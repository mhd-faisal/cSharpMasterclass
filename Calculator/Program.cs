// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello");

Console.WriteLine("Type your first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Type your second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubstract?");
Console.WriteLine("[M]ultiply");

var userChoice = Console.ReadLine();

if (EqualsCaseInsensitive(userChoice, "A"))
{
    var sum = firstNumber + secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, sum, "+");
}

else if (EqualsCaseInsensitive(userChoice, "S"))
{
    var difference = firstNumber - secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, difference, "-");

}

else if (EqualsCaseInsensitive(userChoice, "M"))
{
    var multiplied = firstNumber * secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid Choice!");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

void PrintFinalEquation (
    int firstNumber, int secondNumber, int result, string @operator)
{
    Console.WriteLine(
        firstNumber + " " + @operator + " " + secondNumber + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}