﻿public abstract class Part
{
    public int PartID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int Min {  get; set; }
    public int Max { get; set; }
    public bool? BelongsToProduct { get; set; }
    protected Part(int partID, string name, decimal price, int inStock, int min, int max, bool? belongsToProduct)
    {
        PartID = partID;
        Name = name;
        Price = price;
        InStock = inStock;
        Min = min;
        Max = max;
        this.BelongsToProduct = belongsToProduct;
    }
}

