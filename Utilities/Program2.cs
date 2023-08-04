internal class Program2
{
    public static void Main(string[] args)
    {
        var input = new int[] { 1, 2, 5, 4, 7, 8 };
        var result = input.SumOfEvenNumbers();
        Console.WriteLine(result);
        Console.ReadKey();
    }
}