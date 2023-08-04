// See https://aka.ms/new-console-template for more information

/*
 
//--
char ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            return 'A';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return 'C';
        case 2:
        case 1:
            return 'D';
        case 0:
            return 'E';
        default:
            return '!';
    }
 }

var number = 0;

while(number < 10)
{
    number++;
    Console.WriteLine("Number is: " + number);
}

Console.WriteLine("The loop is finished");
Console.ReadKey();
//--

//--
Console.WriteLine("Enter a word");
var userInput = Console.ReadLine();

while(userInput.Length < 15)
{
    userInput += 'a';
    //userInput = userInput + 'a';

    Console.WriteLine(userInput);
}

Console.WriteLine("The loop has finished.");
Console.ReadKey();
//--

//--
namespace Coding.Exercise
{
    public class Exercise
    {
        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            int currentNumber = firstNumber;
            int sum = 0;
            while (currentNumber <= lastNumber)
            {
                sum += currentNumber;
                currentNumber++;
            }
            return sum;
        }
    }
}
//--

//do-while loop example
using System.Diagnostics.Tracing;

string word;
do
{
    Console.WriteLine("Enter a word longer than 10 letters");
    word = Console.ReadLine();
}
while (word.Length <= 10) ;

Console.WriteLine("The loop is finished");
Console.ReadKey();  



--
for(int i = 10; i > 5; i--)
{
    Console.WriteLine("Loop run " + i);
}
Console.WriteLine("The loop is finished");
Console.ReadLine();

//int i = 0; -> initialize section
//           -> we declared an int and initialised it with a value of zero
//           -> declared variable can't be outside the loop

//i < 5; -> condition section, determines whether the loop should be executed
//       -> must be a boolean expression

//++i -> defines what happens after each execution of the body of the loop
//    -> in this example, we raise the loop vairable by 1
//--


//--
//do while loop
int userNumber;
do
{
    Console.WriteLine("Enter a number larger than 10:");
    var userInput = Console.ReadLine();

    if (userInput == "stop") { break; }

    bool isParasableToInt = userInput.All(char.IsDigit);
    if(!isParasableToInt)
    { 
        userNumber = 0;
        continue; }

    userNumber = int.Parse(userInput);
}   while (userNumber <= 10);

Console.WriteLine("This loop has finished");
Console.ReadKey();
--


--
int[] numbers = new int[] {2, 6, 1, 6, 19 };

var sum = 0;
for (var i= 0; i < numbers.Length; ++i)
{
    sum += numbers[i];
}
Console.WriteLine("sum of elements is " + sum);

Console.ReadKey();
--
*/

char[,] letters = new char[2, 3];

letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var height = letters.GetLength(0);
var width = letters.GetLength(1);
Console.WriteLine("Height is " + height);
Console.WriteLine("Width is " + width);
for (var i = 0; i < height; i++)
{
    Console.WriteLine("i is " + i);
    for (var j = 0; j < width; j++)
    {
        Console.WriteLine("j is " + j);
        Console.WriteLine("element is " + letters[i, j]);
    }
}

Console.ReadKey();