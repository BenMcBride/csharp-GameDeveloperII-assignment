// Mage attacks:
//   Fireball = 0
//   Lightning Bolt = 1
//   Staff Strike = 2

// Ranged attacks:
//   Shoot an Arrow = 0
//   Throw a knife = 1

// Melee attacks:
//   Punch = 0
//   Kick = 1
//   Tackle = 2

Mage Milim = new Mage("Milim");
Ranged Vexahlia = new Ranged("Vexahlia");
Melee Grog = new Melee("Grog");

Grog.PerformAttack(Vexahlia, Grog.AttackList[0]);
Grog.PerformAttack(Milim, Grog.Rage());
Vexahlia.PerformAttack(Grog, Vexahlia.AttackList[0]);
Vexahlia.Dash();
Vexahlia.PerformAttack(Grog, Vexahlia.AttackList[0]);
Milim.PerformAttack(Grog, Milim.AttackList[0]);
Milim.Heal(Vexahlia);
Milim.Heal(Milim);