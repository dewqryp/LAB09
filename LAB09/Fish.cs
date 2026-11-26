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
    double calories = FishType == FishType.Cod
        ? Calories * 0.85
        : Calories;

    return calories * Mass / 100;
}

public double RecalculatePrice()
{
    double price = FishType == FishType.Cod
        ? Price * 0.95
        : Price;

    return price * Mass / 100;
}
}
