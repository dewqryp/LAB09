using System.Security.AccessControl;

namespace LAB09;

public class Ingredient
{
    public string Name { get; set; }
    public double Mass { get; set; }
    public double Calories { get; set; }
    public double Price { get; set; }

    public Ingredient(string name, double mass, double calories, double price)
    {
        Name = name;
        Mass = mass;
        Calories = calories;
        Price = price;
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, Mass: {Mass}g, Calories/100g: {Calories}, Price: {Price} rub";
    }
}