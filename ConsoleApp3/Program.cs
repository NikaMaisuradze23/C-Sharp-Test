internal class Program
{

    static int Method(int sigrdze, int sigane)
    {
        return sigrdze * sigane;
    }

    static double Method(double sigrdze, double sigane, double simagle)
    {
        return sigrdze * sigane * simagle;
    }


    private static void Main(string[] args)
    {
        Console.WriteLine("sigrdze: ");
        int sigrdze = int.Parse(Console.ReadLine());

        Console.WriteLine("sigane: ");
        int sigane = int.Parse(Console.ReadLine());

        Console.WriteLine("sigane: ");
        int simagle = int.Parse(Console.ReadLine());


        int fartobi = Method(sigrdze, sigane);
        double moculoba = Method(sigrdze, sigane, simagle);

        Console.WriteLine("fartobi: " + fartobi);
        Console.WriteLine("moculoba " + moculoba);

    }
}