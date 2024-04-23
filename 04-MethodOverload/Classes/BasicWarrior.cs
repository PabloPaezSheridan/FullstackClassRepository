public abstract class BasicWarrior
{
    public int HitPoints {get;set;}
    public string? Civilization {get; set;}
    public virtual int Defense {get; set;}
    public float Attack{get;set;} = 1;
    public int Range{get;set;}
}