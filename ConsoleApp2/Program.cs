internal class Program
{
    private static void Main(string[] args)
    {

        int number;

        Console.WriteLine("Number: ");
        number = int.Parse(Console.ReadLine());

        //string binaryNumber = Convert.ToString(number, 2);
        //Console.WriteLine("Binary: " + binaryNumber);

        string Result = string.Empty;

        for (int i = 0; number > 0; i++)
        {
            Result = number % 2 + Result;
            number = number / 2;
        }
        Console.WriteLine($"Binary: {Result}");

        Console.ReadKey();
    }
    
}