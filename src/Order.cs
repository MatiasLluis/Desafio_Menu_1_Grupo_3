using System.Collections;

namespace Ucu.Poo.Restaurant;

public class Order
{
    public List<Dish> order { get;  set; }
    public Order()
    {
        order = new List<Dish>();
    }
    
    public double GetTotal()
    {
        double total = 0;
        foreach (var dish in order)
        {
            total += dish.Price;
        }

        return total;
    }
}
    
