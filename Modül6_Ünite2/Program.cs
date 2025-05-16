class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(kareal(5));
        Console.WriteLine(kareal(5.1));
        Console.WriteLine(kareal("3"));


    }
    static int kareal(int x)
    {
        return x * x;
    }
    static double kareal(double x)
    {
        return x * x;
    }
    static int kareal(string x)
    {
        return int.Parse(x) * int.Parse(x);
    }
}