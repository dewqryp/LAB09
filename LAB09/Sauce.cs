namespace LAB09;

public enum SauceType
{
    Tomato,
    Creamy,
    Soy
}

public enum Level
{
    Low,
    Medium,
    High
}

public class Sauce : Ingredient, IDiet
{
    public Sauce(string name, double mass, double calories, double price,
        SauceType sauceType, Level spiciness)
        : base(name, mass, calories, price)
    {
        SauceType = sauceType;
        Spiciness = spiciness;
    }

    public SauceType SauceType { get; set; }

    public Level Spiciness { get; set; }

    public double RecalculateCalories()
    {
        return Calories * Mass / 100;
    }

    public double RecalculatePrice()
    {
        return Price * Mass / 100;
    }
}