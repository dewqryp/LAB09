namespace LAB09;

public enum FishType
{
    Salmon,
    Cod,
    Shark
}

public enum Habitat
{
    Sea,
    River
}

public class Fish : Ingredient, IDiet
{
    public Fish(string name, double mass, double calories, double price,
        FishType fishType, Habitat fishHabitat)
        : base(name, mass, calories, price)
    {
        FishType = fishType;
        FishHabitat = fishHabitat;
    }

    public FishType FishType { get; set; }

    public Habitat FishHabitat { get; set; }

    public double RecalculateCalories()
    {
        return Calories * Mass / 100;
    }

    public double RecalculatePrice()
    {
        return Price * Mass / 100;
    }
}