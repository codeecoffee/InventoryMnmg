using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class Product
{
    public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
    public int ProductId { get; set; }
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int Min {  get; set; }
    public int Max { get; set; }

    public void AddAssociatedPart(Part associatedPart) {  AssociatedParts.Add(associatedPart); }
    public Part? LookupAssociatedPart(int partId) { return AssociatedParts.FirstOrDefault(p=> p.PartID == partId); }
    public bool RemoveAssociatedPart(int partId) {
        var part = LookupAssociatedPart(partId);
        if(part != null)
        {
            AssociatedParts.Remove(part);
            return true;
        }
        return false;
    }

}

