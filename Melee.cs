class Melee : Enemy
{
  public Melee(string name, int health = 120) : base(name, health)
  {
    AttackList = new List<Attack>()
    {
      new Attack("Punch", 20),
      new Attack("Kick", 15),
      new Attack("Tackle", 25)
    };
  }

  public Attack Rage()
  {
    Random rand = new Random();
    int idx = rand.Next(AttackList.Count);
    var atk = AttackList[idx];
    atk.DamageAmount += 10;
    return atk;
  }
}