namespace UnityExercises;
class Program
{
    public static void Main()
    {
        Player player = new Player("Sam", 100, 1);
        Enemy enemy = new Enemy("Goblin", 9, 12, 150);

        enemy.Attack(player);
        player.Attack(enemy);
        enemy.EnemyStatus();
        player.PlayerStatus();

    }
}