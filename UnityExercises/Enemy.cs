namespace UnityExercises;

class Enemy
{
    public string Name { get; private set; }
    private int _health;
    private int _damage;
    private int _maxHealth;
    private int _xpReward;

    public Enemy(string name, int health, int damage, int xpreward)
    {
        Name = name;
        Health = health;
        Damage = damage;
        MaxHealth = health;
        XpReward = xpreward; 
    }
    
    public int Health
    {
        get => _health;
        set => _health = value > 0 ? value : 0;
    }

    public int Damage
    {
        get => _damage;
        set => _damage = value > 1 ? value : 1;
    }

    public int MaxHealth
    {
        get => _maxHealth;
        set => _maxHealth = value > 0 ? value : 1;
    }

    public int XpReward
    {
        get => _xpReward;
        set => _xpReward = value >= 1 ? value : 0;
    }

    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks {player.Name} for {Damage} HP");
        player.TakeDamage(Damage);
    }

    public int TakeDamage(int val)
    {
        Health -= val;
        if(Health <= 0)
        {
            Console.WriteLine($"{Name} has been defeated");
            return XpReward;
        }
        Console.WriteLine($"{Name} Health: {Health}/{MaxHealth}");
        return 0;
    }

    public void EnemyStatus()
    {
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} is dead");
            return;
        }
        Console.WriteLine($"{Name} has {Health}/{MaxHealth} HP");
    }
}