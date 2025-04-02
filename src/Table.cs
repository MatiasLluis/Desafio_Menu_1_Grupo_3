namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    public int Number { get; set; }
    public bool IsOccupied { get; set; }
    public List<Dish> Order { get; set; }

    public Table (int number)
    {
        this.Number = Number;
        this.IsOccupied = false;
        this.Order = new List<Dish>();
    }

    public void Occupy()
    {
        this.IsOccupied = true;
    }

    public void Free()
    {
        this.IsOccupied = false;
        this.Order.Clear();
    }

    public void AddToOrder(Dish dish)
    {
        this.Order.Add(dish);
    }
    
    private ArrayList order = new ArrayList();
    
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}