namespace UnityExercises;
class Player
{
    public string Name { get; private set; }
    private int _health;
    private int _level;
    private int _experience;

    public Player(string name, int health, int level)
    {
        Health = health;
        Name = name;
        Level = level;
        Experience = 0;
    }

    public int Health
    {
        get => _health;
        set => _health = value < 0 ? 0 : value;
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
        Experience = val;
        while(Experience > 100)
        {
            Level++;
            Experience -= 100;
        }
    }
    
    public void PlayerStatus()
    {
        Console.WriteLine($"{Name} at Level {Level} has {Health} HP and {Experience} XP");
    }
}