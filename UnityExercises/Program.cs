namespace UnityExercises;
class Program
{
    public static void Main()
    {
        Player player = new Player("Sam", 100, 1);
        Console.WriteLine("hello");
        player.PlayerStatus();
        player.TakeDamage(50);
        player.AddExperience(239);
        player.PlayerStatus();
        player.Heal(700);
        player.PlayerStatus();
    }
}