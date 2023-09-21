using System;
public class MyClass
{
    

    public static void Main()
    {
        Console.WriteLine("How many trainee do you want to add ?");
        int num = int.Parse(Console.ReadLine());

        customArraylist  trainees = new customArraylist(num);

        for (int i = 0; i < trainees.Count; i++)
        {
            Console.WriteLine("Enter ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ID");
            string name = Console.ReadLine();
            trainees[i] = new Trainee() { Id = id, Name = name };
        }
        int perlen=trainees.Count;
        Console.WriteLine("How many Trainees do you want to add more ?");
        int more = int.Parse(Console.ReadLine());
        for (int i = perlen; i< more+perlen; i++)
        {
            Console.WriteLine("Enter ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            trainees.Add( new Trainee() { Id = id, Name = name });
        }
        Console.WriteLine("---");
        foreach ( var trainee in trainees)
        {
            Console.WriteLine(trainee);
        }

    }
}