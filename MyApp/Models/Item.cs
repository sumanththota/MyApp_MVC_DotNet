namespace MyApp.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    
    //we want to get these items using /items/overview
    //we need to create a controller named items and a method named overview
}