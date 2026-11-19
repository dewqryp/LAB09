
namespace LAB09;

using System;
using System.Collections.Generic;

public class Dish
{
    public string Name { get; set; }

    public List<Ingredient> Ingredients { get; set; }

    public Dish(string name)
    {
        Name = name;
        Ingredients = new List<Ingredient>();
    }

    public void AddToDish(Ingredient ingredient)
    {
        if (ingredient is Meat && Ingredients.Exists(i => i is Fish))
        {
            throw new Exception("Нельзя добавлять мясо и рыбу в одно блюдо");
        }

        if (ingredient is Fish && Ingredients.Exists(i => i is Meat))
        {
            throw new Exception("Нельзя добавлять мясо и рыбу в одно блюдо");
        }

        if (ingredient is Sauce sauce &&
            Ingredients.Exists(i => i is Sauce s && s.SauceType != sauce.SauceType))
        {
            throw new Exception("Нельзя добавлять соусы разных типов");
        }

        Ingredients.Add(ingredient);
    }

    public double TotalCalories()
    {
        double total = 0;

        foreach (Ingredient ingredient in Ingredients)
        {
            if (ingredient is IDiet diet)
                total += diet.RecalculateCalories();
            else
                total += ingredient.Calories * ingredient.Mass / 100;
        }

        return total;
    }

    public double TotalCost()
    {
        double total = 0;

        foreach (Ingredient ingredient in Ingredients)
        {
            if (ingredient is IDiet diet)
                total += diet.RecalculatePrice();
            else
                total += ingredient.Price * ingredient.Mass / 100;
        }

        return total;
    }

    public override string ToString()
    {
        return $"Блюдо: {Name}, калории: {TotalCalories()}, стоимость: {TotalCost()}";
    }

    public static bool operator ==(Dish a, Dish b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        return a.TotalCost() == b.TotalCost() &&
               a.TotalCalories() == b.TotalCalories();
    }

    public static bool operator !=(Dish a, Dish b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        return obj is Dish dish && this == dish;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(TotalCost(), TotalCalories());
    }
}
