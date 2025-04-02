namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish

{
    public string Name { get; set; }
    public int Price { get; set; }
    public string IsVegetarian { get; set; }

    public Dish (string Name, int Price, string IsVegetarian)
    {
        Name = Name; 
        Price = Price;
        IsVegetarian = IsVegetarian;
    }


}