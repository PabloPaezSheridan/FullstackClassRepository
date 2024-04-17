Address dir1 = new Address()
{
    Apartment = "9a",
    City = "Rosario",
    Country = "Argentina",
    State = "Santa Fe",
    Floor = "9",
    Street = "Santa Fe",
    PostalCode = 2000
};


Buyer buyer1 = new()
{
    Alias = "Pedro Jimenez",
    Level = 2,
    Username = "pedroji",
    Password = "pass",
    Addresses = new List<Address> (){dir1}
};

Console.WriteLine(buyer1.Addresses[0].City);


Seller seller1 = new()
{
    CompanyName = "Zaraza",
    CUIT = "44555454",
    Username = "ventaspormayorymenor",
    Password = "pass",
    Categories = new List<Category>(){
        new Category(){Code = 5, Description= "Ferreteria"},
        new Category(){Code = 6, Description = "Muebleria"}
    } 
};


foreach(Category cat in seller1.Categories)
{
    Console.WriteLine(cat.Code + ": " + cat.Description);
}