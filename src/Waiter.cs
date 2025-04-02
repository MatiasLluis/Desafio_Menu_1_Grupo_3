using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    public string Nombre_mozo { get; set; }
    
    private ArrayList assignedTables = new ArrayList();

    public void assign_table(Table table)
    {
        String mesa_asignada = "";
        for (int i = 0; i < Table.Count)
        {
            
        }
    }
    
}

