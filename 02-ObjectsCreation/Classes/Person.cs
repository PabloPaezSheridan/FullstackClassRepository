public class Person
{
    public double Height {get; set;}

    public string GetHeight()
    {
        if(Height > 1.8)
            return "soy alto";
        return "no soy alto pero tengo alma grande";
    } 
}