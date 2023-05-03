public class Enemy
{
    public string Name { get; protected set; }= "";

    public int Health { get; protected set; } = 100;

    public List<Attack> AttackList { get;protected set; }

    protected Random rand = new Random();


    public Enemy(string Name, List<Attack> AttackList)
    {
        this.Name = Name;
        this.AttackList = AttackList;
    }

    public Enemy(string Name, int Health, List<Attack> AttackList) { this.Name = Name; this.AttackList = AttackList; this.Health = Health; }

    public void AddAttack(Attack A) => this.AttackList.Add(A);

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }

    public void HPMod(int Amount) => this.Health += Amount;


    public Attack RandomAttack() => this.AttackList[rand.Next(this.AttackList.Count)];
}