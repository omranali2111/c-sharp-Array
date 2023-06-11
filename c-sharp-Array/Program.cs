using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = { 1, 5, 7, 9, 10 };
        int sum = 0;
        for(int i=0; i<a.Length; i++)
        {
            sum = sum + a[i];

        }

        WriteLine(sum);
    }
}