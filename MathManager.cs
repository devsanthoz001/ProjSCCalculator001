public class MathManager
{
    public static void Main(string[] args)
    {
        MathManager Calculate = new MathManager();
        Calculate.Add3Nos();
        Calculate.Add5Nos(10);
        int TotalOf7 = Calculate.Add7Nos(10,15,25,10);
        System.Console.Write("sumof7NosIs");
        System.Console.WriteLine(TotalOf7);
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
    public int Add7Nos(int a, int b, int c, int d)
    {
        int e = 20;
        int f = 10;
        int g = 30;
        int sumof7Nos= a+b+c+d+e+f+g;
        return sumof7Nos;
    }
}