namespace UnityExercises;
class Player
{
    public string Name { get; private set; }
    private int _health;
    private int _level;
    private int _experience;
    private int _maxHealth;

    public Player(string name, int health, int level)
    {
        Health = health;
        Name = name;
        Level = level;
        Experience = 0;
        MaxHealth = health;
    }

    public int Health
    {
        get => _health;
        set => _health = value < 0 ? 0 : value;
    }
    public int MaxHealth
    {
        get => _maxHealth;
        private set => _maxHealth = value < 1 ? 1 : value;
    }
    public int Level
    {
        get => _level;
        set => _level = value >= 1 ? value : 1;
    }

    public int Experience
    {
        get => _experience;
        private set => _experience = value; 
    }

    public void TakeDamage(int val)
    {
        Health -= val;
    }

    public void AddExperience(int val)
    {
        // int temp = Experience + val;
        // if (temp >= 100)
        // {
        //     Level++;
        //     temp -= 100;
        // }
        // Experience = temp;

        //better version;
        Experience += val;
        while (Experience > 100)
        {
            LevelUp();
            Experience -= 100;
        }
    }

    private void LevelUp()
    {
        MaxHealth += 10;
        Level++;
        Health = MaxHealth;
    }
    
    public void Heal(int amount)
    {
        Health += amount;
        if(Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }
    public void PlayerStatus()
    {
        Console.WriteLine($"{Name} at Level {Level} has {Health}/{MaxHealth} HP and {Experience} XP");
    }
}