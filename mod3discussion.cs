using System;

class Octopus
{
    // Readonly fields
    public readonly string Name;
    public readonly int Legs = 8;

    // Regular field
    public int Age = 10;

    // Constructor
    public Octopus(string name)
    {
        Name = name;
    }

    // Method to display octopus information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Legs: {Legs}");
    }
}

class Program
{
    static void Main()
    {
        // Create an Octopus object and display its info
        Octopus octopus = new Octopus("Jack");
        octopus.DisplayInfo();
    }
}
