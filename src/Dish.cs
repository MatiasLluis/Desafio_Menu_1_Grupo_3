namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish

{
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsVegetarian { get; set; }

    public Dish (string Name, double Price, bool IsVegetarian)
    {
        Name = Name; 
        Price = Price;
        IsVegetarian = IsVegetarian;
    }


}