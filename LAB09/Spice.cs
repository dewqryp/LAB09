namespace LAB09;

public enum FlavorLevel
{
    Low,
    Medium,
    High
}

public class Spice : Ingredient
{
    public Spice(string name, double mass, double calories, double price,
        string flavor, FlavorLevel flavorLevel)
        : base(name, mass, calories, price)
    {
        Flavor = flavor;
        FlavorLevel = flavorLevel;
    }

    public string Flavor { get; set; }

    public FlavorLevel FlavorLevel { get; set; }
}