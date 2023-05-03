// Worked with David,Kirstie,and Minh 

List<Attack> L = new List<Attack>
{
    new Attack("Punch", 20),
    new Attack("Kick", 40),
    new Attack("Headbutt", 60)
};

Enemy Y = new Enemy("Thanos",150,L);

Console.WriteLine(Y.RandomAttack().Name);

Console.WriteLine(Y.Health); 
Y.AddAttack(new Attack("Knee", 30));

foreach(Attack A in Y.AttackList){Console.WriteLine(A.Name);} 
