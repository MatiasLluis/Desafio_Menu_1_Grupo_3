namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    public int Number { get; set; }
    public bool IsOccupied { get; set; }
    public list List<Dish> Order { get; set; }
    
    private ArrayList order = new ArrayList();
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}