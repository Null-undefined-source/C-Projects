public class Person
{
    public string? Name { get; set; }
    public void SayName()
    {
        Console.WriteLine($"My name is {Name}");
    }
}