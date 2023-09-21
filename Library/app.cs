using System.Text;
public class Program
{
    public static void Main()
    {
        customArraylist arr = new customArraylist(10) { 10, 15, 20 };
        arr[3] = 5;
        Console.WriteLine(arr.Count);
        Console.WriteLine(arr.Capacity);
        Console.WriteLine();
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        arr.trimExcess();
        Console.WriteLine(arr.Count);
        Console.WriteLine(arr.Capacity);

    }
}