namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private Order pedidos = new Order();
    public int Number { get; set; }
    public bool IsOccupied { get; set; }

    public Table (int number)
    {
        this.Number = number;
        this.IsOccupied = false;
    }

    public void Occupy()
    {
        this.IsOccupied = true;
        this.pedidos = new Order();
    }

    public void Free()
    {
        this.IsOccupied = false;
        this.pedidos.order.Clear();
    }

    public void AddToOrder(Dish dish)
    {
        this.pedidos.order.Add(dish);
    }
    
    public bool HasOrders()
    {
        return this.pedidos.order.Count > 0;
    }
}