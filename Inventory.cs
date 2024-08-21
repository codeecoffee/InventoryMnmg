using System;
using System.ComponentModel;
using System.Linq;

public class Inventory
{
    public BindingList<Product> Products { get; set; } = new BindingList<Product>();
    public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

    private static int partIdCounter = 1;
    public static int GeneratePartId()
    { 
        return partIdCounter++; 
    }
    public Product? lookupProduct(int productId) 
    {
        return Products.FirstOrDefault(p=> p.ProductId == productId);
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public bool RemoveProduct(int productId)
    {
        var product = lookupProduct(productId);
        if (product != null)
        {
            Products.Remove(product);
        }
        return false;
    }
    public void updateProduct(int productId, Product updatedProduct)
    {
        var product = lookupProduct(productId);
        if (product != null)
        {
            int index = Products.IndexOf(product);
            Products[index] = updatedProduct;
        }
    }

    public void AddPart(Part part)
    {
        AllParts.Add(part);
    }
    public bool DeletePart(Part part) 
    {
        return AllParts.Remove(part);
    }
    public Part? lookupPart(int partId)
    {
        return AllParts.FirstOrDefault(p=> p.PartID == partId);
    }
    public void updatePart(int partId, Part updatedPart)
    {
        var part = lookupPart(partId);
        if (part != null)
        {
            int index = AllParts.IndexOf(part);
            AllParts[index] = updatedPart;
        }

    }
}
