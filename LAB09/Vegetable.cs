namespace LAB09;

public enum Season
{
    Summer,
    Autumn,
    Winter,
    Spring
}

public class Vegetable : Ingredient, IDiet
{
    public Vegetable(string name, double mass, double calories, double price,
        bool isOrganic, Season season)
        : base(name, mass, calories, price)
    {
        IsOrganic = isOrganic;
        Season = season;
    }

    public bool IsOrganic { get; set; }

    public Season Season { get; set; }

    public double RecalculateCalories()
    {
        return Calories * Mass / 100;
    }

    public double RecalculatePrice()
    {
        return Price * Mass / 100;
    }
}