namespace UnityExercises;
class Program
{
    public static void Main()
    {
        Player player = new Player("Sam", 100, 1);
        Console.WriteLine("hello");
        player.PlayerStatus();
        player.AddExperience(239);
        player.PlayerStatus();
    }
}