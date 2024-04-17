public class Buyer:User
{
    public string Alias { get; set; }
    public int Level { get; set; }
    public List<Address> Addresses {get;set;}
}