class Attack
{

    public string Name { get; protected set; }

    public int DamageAmount { get; protected set; }

    public Attack(string Name, int DamageAmount)
    {
        this.Name = Name;
        this.DamageAmount = DamageAmount;
    }

}

