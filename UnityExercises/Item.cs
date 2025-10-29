namespace UnityExercises;

abstract class Item
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public bool IsConsumeable { get; protected set; }

    public abstract void Use(Player player);
}

class HealthPotion : Item
{
    private int healAmount;

    public HealthPotion(int healAmount)
    {
        Name = "Health Potion";
        Description = $"Restores {healAmount} HP";
        IsConsumeable = true;
        this.healAmount = healAmount;
    }

    public override void Use(Player player)
    {
        Console.WriteLine($"{player.Name} uses {Name}");
        player.Heal(healAmount);
    }
}

class DamageScroll : Item
{
    private int damageIncrese;
    public DamageScroll(int damageAmount)
    {
        Name = "Damage Scroll";
        Description = $"Increases Damage dealt by {damageAmount}";
        IsConsumeable = true;
        this.damageIncrese = damageAmount;
    }
    public override void Use(Player player)
    {
        Console.WriteLine($"{player.Name} uses {Name}");
        player.Damage += damageIncrese;
    }
}