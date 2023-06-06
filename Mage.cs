class Mage : Enemy
{
  public Mage(string name, int health = 80) : base(name, health)
  {
    AttackList = new List<Attack>()
    {
      new Attack("Fireball", 25),
      new Attack("Lightning Bolt", 20),
      new Attack("Staff Strike", 10)
    };
  }

  public void Heal(Enemy Target)
  {
    if (Target.Status == "Dead")
    {
      Console.WriteLine($"Can't heal because {Target.Name} is dead.");
      return;
    }
    Target._Health += 40;
    if (Target._Health > Target.MaxHealth)
    {
      var difference = Target._Health - Target.MaxHealth;
      Target._Health = Target.MaxHealth;
      Console.WriteLine($"{Name} heals {Target.Name} for the {difference} Health they were missing, putting them at their Max Health!");
    }
    else
    {
      Console.WriteLine($"{Name} heals {Target.Name} for 40 Health, making their new health {Target._Health}");
    }
  }
}