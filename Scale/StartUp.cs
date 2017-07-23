using System;

public class StartUp
{
    public static void Main()
    {
        var left = int.Parse(Console.ReadLine());
        var right = int.Parse(Console.ReadLine());

        Scale<int> scale = new Scale<int>(left, right);

        Console.WriteLine(scale.GetHavier());
    }
}