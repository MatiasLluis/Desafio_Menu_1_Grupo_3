namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    public int Number { get; set; }
    public bool IsOccupied { get; set; }
    public List<Dish> Order { get; private set; }

    public Table (int number)
    {
        this.Number = number;
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
    
    public bool HasOrders()
    {
        return this.Order.Count > 0;
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (var dish in Order)
        {
            total += dish.Price;
        }

        return total;
    }
}