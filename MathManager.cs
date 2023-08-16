public class MathManager
{
    public static void Main(string[] args)
    {
        MathManager Calculate = new MathManager();
        Calculate.Add3Nos();
    }
    public void Add3Nos()
    {
        int a = 31;
        int b = 29;
        int c = 35;
        int sumof3Nos = a + b + c;
        System.Console.WriteLine(sumof3Nos);
    }
}