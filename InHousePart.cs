public class InHousePart : Part
{
    public int MachineId {get; set;}

    public InHousePart(int partID, string name, decimal price, int inStock, int min, int max, int machineId, bool belongsToProduct)
        : base(partID, name, price, inStock, min, max, belongsToProduct) 
    {
        MachineId = machineId;
    
    }  
}
