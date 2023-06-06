public class Enemy
{
  public string Name { get; set; }
  public List<Attack> AttackList { get; set; }
  protected int Health { get; set; }
  public int MaxHealth { get; set; }
  public string Status { get; set; }
  public int _Health
  {
    get
    {
      return Health;
    }
    set
    {
      Health = value;
    }
  }

  // Constructor
  public Enemy(string name, int health = 100)
  {
    Name = name;
    Health = health;
    MaxHealth = health;
    AttackList = new List<Attack>();
    Status = "Alive";
  }

  public void AddAttack(Attack attack)
  {
    AttackList.Add(attack);
  }
  public Attack RandomAttack()
  {
    Random rand = new Random();
    int idx = rand.Next(AttackList.Count);
    return AttackList[idx];
  }
  public void PerformAttack(Enemy Target, Attack ChosenAttack)
  {
    if (this is Ranged && (this as Ranged).Distance < 10)
    {
      Console.WriteLine($"{Name} is too close to their perform Ranged attack");
      return;
    }
    if (Target.Status == "Dead")
    {
      Console.WriteLine($"Can't attack because {Target.Name} is dead.");
      return;
    }
    Target.Health -= ChosenAttack.DamageAmount;
    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    if (Target.Health <= 0)
    {
      Target.Status = "Dead";
      Console.WriteLine($"{Target.Name} has died!");
    }
  }
}