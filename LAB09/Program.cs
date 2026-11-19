using LAB09;

Dish chickenRice = new Dish("Куриная грудка с рисом");

chickenRice.AddToDish(new Meat(
    "Куриная грудка", 200, 165, 12,
    MeatType.Chicken, 5));

chickenRice.AddToDish(new Ingredient(
    "Рис", 150, 130, 4));

chickenRice.AddToDish(new Vegetable(
    "Огурец", 100, 15, 3,
    true, Season.Summer));


try
{
    chickenRice.AddToDish(new Fish(
        "Лосось", 180, 208, 25,
        FishType.Salmon, Habitat.Sea));
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Проверка мяса и рыбы: {ex.Message}");
}



Dish fishVegetables = new Dish("Рыба с овощами");

fishVegetables.AddToDish(new Fish(
    "Лосось", 180, 208, 25,
    FishType.Salmon, Habitat.Sea));

fishVegetables.AddToDish(new Vegetable(
    "Помидор", 120, 18, 5,
    true, Season.Summer));

fishVegetables.AddToDish(new Sauce(
    "Соевый соус", 30, 53, 8,
    SauceType.Soy, Level.Low));



try
{
    fishVegetables.AddToDish(new Meat(
        "Свинина", 200, 242, 18,
        MeatType.Pork, 20));
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Проверка рыбы и мяса: {ex.Message}");
}



try
{
    fishVegetables.AddToDish(new Sauce(
        "Томатный соус", 40, 50, 6,
        SauceType.Tomato, Level.Medium));
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Проверка соусов: {ex.Message}");
}



Dish porkPotatoes = new Dish("Свинина с картофелем");

porkPotatoes.AddToDish(new Meat(
    "Свинина", 200, 242, 18,
    MeatType.Pork, 20));

porkPotatoes.AddToDish(new Vegetable(
    "Картофель", 180, 77, 4,
    false, Season.Autumn));

porkPotatoes.AddToDish(new Spice(
    "Паприка", 5, 282, 10,
    "Острый", FlavorLevel.Medium));



Console.WriteLine();
Console.WriteLine("Список блюд:");
Console.WriteLine(chickenRice);
Console.WriteLine(fishVegetables);
Console.WriteLine(porkPotatoes);



Console.WriteLine();
Console.WriteLine("Сравнение блюд:");

Console.WriteLine(
    $"Курица с рисом == рыба с овощами: {chickenRice == fishVegetables}");

Console.WriteLine(
    $"Свинина с картофелем == рыба с овощами: {porkPotatoes == fishVegetables}");