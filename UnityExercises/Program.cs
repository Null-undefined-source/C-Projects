namespace UnityExercises;
class Program
{
    public static void Main()
    {
        Player player = new Player("Sam", 100, 1);
        Enemy enemy = new Enemy("Goblin", 9, 12, 150);
        HealthPotion hp = new HealthPotion(12);
        enemy.Attack(player);
        player.AddItem(hp);
        player.ShowInventory();
        player.UseItem("Health Potion");
        player.PlayerStatus();

    }
}