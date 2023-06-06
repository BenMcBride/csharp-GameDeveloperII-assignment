class Ranged : Enemy
{
  public int Distance { get; set; }
  public Ranged(string name, int health = 100, int distance = 5) : base(name, health)
  {
    Distance = distance;
    AttackList = new List<Attack>()
    {
      new Attack("Shoot an Arrow", 20),
      new Attack("Throw a Knife", 15)
    };
  }

  public void Dash()
  {
    this.Distance = 20;
  }
}