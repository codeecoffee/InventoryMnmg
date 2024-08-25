using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }
    public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

    public Product(BindingList<Part> associatedParts, int productId, string name, decimal price, int inStock, int min, int max) 
    { 
        AssociatedParts = associatedParts;
        Name = name;
        Price = price;
        InStock = inStock;
        Min = min;
        Max = max;

        //update the BelongsToProduct property for each associated part
        foreach (var part in associatedParts) part.BelongsToProduct = true;
    }

    public void AddAssociatedPart (Part associatedPart)=>AssociatedParts.Add(associatedPart);
    public Part? LookupAssociatedPart(int partId) => AssociatedParts.FirstOrDefault(p=>p.PartID == partId);
    public bool RemoveAssociatedPart(int partId)
    {
        var part = LookupAssociatedPart(partId);
        if(part != null)
        {
            AssociatedParts.Remove(part);
            return true;
        }
        return false;
    }

}

