using System.Text;
public class Program
{
    public static void Main()
    {
        customArraylist arr = new customArraylist(10) { 10, 15, 20,2};
        arr[3] = 5;
        Console.WriteLine(arr.Count);
        Console.WriteLine(arr.Capacity);
        Console.WriteLine();
        arr.Remove_At(0);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        arr.trimExcess();
        Console.WriteLine(arr.Count);
        Console.WriteLine(arr.Capacity);
    }
}