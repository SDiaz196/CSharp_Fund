class Enemy
{

    public string Name { get; protected set; } = "";

    public List<Attack> AttackList { get; }

    public int Health { get; protected set; } = 100;

    Random rand = new Random();

    public Enemy(string Name, List<Attack> AttackList)
    {
        this.Name = Name;
        this.AttackList = AttackList;
    }

    public Enemy(string Name, int Health, List<Attack> AttackList) { this.Name = Name; this.AttackList = AttackList; this.Health = Health; }
    public void AddAttack(Attack A) => this.AttackList.Add(A);

    public Attack RandomAttack() => this.AttackList[rand.Next(this.AttackList.Count)];
}

