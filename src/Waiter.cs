using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    public string Name { get; set; }
    
    private ArrayList assignedTables = new ArrayList();
    public Waiter(string name)
    {
        this.Name = name;
    }
    public void assign_table(Table table)
    {
        assignedTables.Add(table);
    }

    public void TakeOrder(Table table, Dish dish)
    {
        table.AddToOrder(dish);
    }
    
}