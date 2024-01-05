internal class Program
{
    private static void Main(string[] args)
    {
        // sort
        int[] numberArray = { 23, 12, 4, 86, 72, 3, 11, 17 };
        // .sırasız dizi
        Console.WriteLine("Sırasız Array");
        foreach (var item in numberArray)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Sıralı Array");
        Array.Sort(numberArray);

        foreach (var number in numberArray)
            Console.WriteLine(number);

        // Clear

        Console.WriteLine("Array Clear");
        Array.Clear(numberArray, 2, 2);

        foreach (var item in numberArray)
        {
            Console.WriteLine(item);
        }

        // Reverse
        Console.WriteLine("Array Reverse");

        Array.Reverse(numberArray);

        foreach (var item in numberArray)
        {
            Console.WriteLine(item);
        }

        // IndexOf
        Console.WriteLine("Array IndexOf");

        Console.WriteLine(Array.IndexOf(numberArray, 23));

        // Resize
        Console.WriteLine("Array Resize");

        Array.Resize<int>(ref numberArray, 9);

        numberArray[8] = 99;

        foreach (var item in numberArray)
        {
            Console.WriteLine(item);
        }

    }
}