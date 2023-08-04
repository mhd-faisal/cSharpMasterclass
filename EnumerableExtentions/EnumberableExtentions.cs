// See https://aka.ms/new-console-template for more information

public static class EnumberableExtentions
{
    public static int SumOfEvenNumbers(this IEnumerable<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                sum += number;
            }
        }    
        return sum;
    }
}