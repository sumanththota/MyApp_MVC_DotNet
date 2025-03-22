using System.ComponentModel.DataAnnotations;

namespace MyApp.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = null!; //make sure that the name is not null
    public double Price { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative.")]
    public int Quantity { get; set; }
    
    
    
    
    //we want to get these items using /items/overview
    //we need to create a controller named items and a method named overview
}