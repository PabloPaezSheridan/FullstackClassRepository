public class Militia : Infantry
{
    public Militia()
    {
        Defense += 1; 
        Attack += Attack/3;   
    }

    public Militia(int hitPoints, string civilization)
    {
        Defense += 1; 
        Attack += Attack/3;   
        HitPoints = hitPoints;
        Civilization = civilization;
        if(Civilization == "Celts")
        {
            Attack += 2;
        }
    }

    public Militia(int hitPoints, int defense)
    {
        HitPoints = hitPoints;
        Defense = defense;
    }
}