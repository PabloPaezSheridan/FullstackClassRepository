public class Infantry : BasicWarrior
{
    public override int Defense {get; set;} = 1;
    public Infantry()
    {
        Defense = 1;
        Attack = Attack*2;
    }

}