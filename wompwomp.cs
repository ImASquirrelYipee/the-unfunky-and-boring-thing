using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello kind user. This program contains the answers to the universe. Just enter your name!");
        string name = Console.ReadLine();
        Console.WriteLine("Alright, that's great " + name + ". So, this is a bit awkward, but would you mind just reminding me of my name?");
        string computerName = Console.ReadLine();
        Console.WriteLine("Right so I'm " + computerName + ". Thanks for your help, " + name + ".");
        if (computerName == "w")
        Console.WriteLine("You have cancer!");
    }
}