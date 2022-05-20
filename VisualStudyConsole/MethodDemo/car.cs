using System;

public class Car
{
    public Car()
    {

    }

    public void Map(ref string title)
    {
         title = "참조 변경";
         Console.WriteLine($"[2]{title}");
    }

    public void Map(out int num) {
        num = 100;
        Console.WriteLine($"[2]{num}");
    } 

    public void Map(params string[] arr)
    {
        foreach(var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintMessage(string message, string prefix = "", string suffix = "")
    {
        Console.WriteLine($"{prefix} - {message} - {suffix}");
    }

   
}
