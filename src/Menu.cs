using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    public ArrayList AddDish(Dish dish)
    {
        dishes.Add(dish);
        return dishes;
    }

    public ArrayList RemoveDish(Dish dish)
    {
        dishes.Remove(dish);
        return dishes;
    }

    public Dish GetDishByName(string name)
    {
        foreach (Dish dish in dishes)
        {
            if (dish.Name == name)
            {
                return dish;
            }
        }
        return null;
    }
}