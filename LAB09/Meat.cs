namespace LAB09;

public enum MeatType
{
    Beef,
    Chicken,
    Pork
}

public class Meat : Ingredient, IDiet
{
    public MeatType MeatType { get; set; }

    public double FatPercentage { get; set; }

    public Meat(string name, double mass, double calories, double price,
        MeatType meatType, double fatPercentage)
        : base(name, mass, calories, price)
    {
        MeatType = meatType;
        FatPercentage = fatPercentage;
    }

public double RecalculateCalories()
{
    double dietaryCalories = Math.Max(0, Calories - FatPercentage * 9);

    return dietaryCalories * Mass / 100;
}

public double RecalculatePrice()
{
    double price = FatPercentage <= 10
        ? Price * 0.95
        : Price;

    return price * Mass / 100;
}
}
