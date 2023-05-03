public class RangedFighter : Enemy
{
    int Distance = 5;
    public RangedFighter():base("Ranged Fighter",new List<Attack>())
    {
        this.AttackList = new List<Attack> 
        {
            new Attack("Shoot an Arrow", 20),
            new Attack("Throw a Knife", 15)
        }; 
    } 

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance < 10)
        {
            Console.WriteLine("Cannot shoot, distance too short!");
        } 
        else 
        {
            base.PerformAttack(Target, ChosenAttack);
        }
    }
    public void Dash() => Distance = 20;
}