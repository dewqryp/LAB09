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
        return (Calories - FatPercentage / 100 * 8) * Mass / 100;
    }

    public double RecalculatePrice()
    {
        return Price * Mass / 100;
    }
}