public class MathManager
{
    public static void Main(string[] args)
    {
        MathManager Calculate = new MathManager();
        Calculate.Add3Nos();
        Calculate.Add5Nos(10);
    }
    public void Add3Nos()
    {
        int a = 31;
        int b = 29;
        int c = 35;
        int sumof3Nos = a + b + c;
        System.Console.WriteLine(sumof3Nos);
    }
    public void Add5Nos(int a)
    {
        int b = 10;
        int c = 21;
        int d = 10;
        int e = 14;
        int sumof5Nos= a+b+c+d+e;
        System.Console.WriteLine(sumof5Nos);
    }
}