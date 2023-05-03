// Worked with David,Kirstie,and Minh 


MeleeFighter Melee = new MeleeFighter();
RangedFighter Ranged = new RangedFighter();
MagicCaster Magic = new MagicCaster(); 

Melee.PerformAttack(Ranged ,Melee.AttackList[1]);
Melee.PerformAttack(Magic,Melee.Rage()); 
Ranged.PerformAttack(Melee,Ranged.AttackList[0]); 
Ranged.Dash();
Ranged.PerformAttack(Melee,Ranged.AttackList[0]); 
Magic.PerformAttack(Melee,Magic.AttackList[0]); 
Magic.Heal(Ranged);
Magic.Heal(Magic);