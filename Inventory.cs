using System;
using System.ComponentModel;
using System.Linq;

public class Inventory
{
    private static Inventory _instance = new Inventory();
    private Inventory() { }
    public static Inventory Instance
    { get { return _instance; } }
    public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
    public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

    private static int partIdCounter = 0;
    private static int productIdCounter = 0;

    public static int GeneratePartId()
    { 
        return partIdCounter++; 
    }
    public static int GenerateProductId()
    {
        return productIdCounter++;
    }
    public Product? lookupProduct(int productId) 
    {
        return Products.FirstOrDefault(p=> p.ProductId == productId);
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public bool DeleteProduct(Product product)
    {
        var prod = lookupProduct(product.ProductId);
        if (prod != null)
        {
            foreach (var part in prod.AssociatedParts)
            {
                if (CanDeletePart(part))
                {
                    prod.RemoveAllAssociatedParts();
                }
            }
            return Products.Remove(prod);

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
    public static BindingList<Product> GetAllProducts()
    {
        return Products;
    }

    public static BindingList <Product> SearchProductByName(string name)
    {
        var results = new BindingList<Product>(Products.Where(p=> p.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >=0).ToList());
        return results;
    }
    public static Product? SearchProductsById(int productId) { return Products.FirstOrDefault(p => p.ProductId == productId); }
    public static BindingList<Product> SearchProductsByPrice(decimal price)
    {
        //var results = new BindingList<Product>(Products.Where(p => p.Price == price).ToList());
        //return results;
        return new BindingList<Product>(Products.Where(p => p.Price == price).ToList());
    }

    public Part? lookupPart(int partId)
    {
        return AllParts.FirstOrDefault(p => p.PartID == partId);
    }
    public void AddPart(Part part)
    {
        AllParts.Add(part);
    }
    public bool DeletePart(Part part) 
    {
        if (CanDeletePart(part)) return AllParts.Remove(part);
        else
        {
            MessageBox.Show("Cannot delete the part because it is associated with one or more products.");
            return false;
        }
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
    public static BindingList<Part> GetAllParts()
    { 
        return AllParts;
    }
    public static BindingList<Part> SearchPartsByName(string name)
    {
        var results = new BindingList<Part>(AllParts.Where(p => p.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
        return results;
    }
    // Search parts by ID
    public static Part? SearchPartsById(int partId)
    {
        return AllParts.FirstOrDefault(p => p.PartID == partId);
    }
    // Search parts by price
    public static BindingList<Part> SearchPartsByPrice(decimal price)
    {
        var results = new BindingList<Part>(AllParts.Where(p => p.Price == price).ToList());
        return results;
    }

    public static bool CanDeletePart(Part part)
    {
        foreach(var product in Products)
        {
            if (product.AssociatedParts.Contains(part)) return false;
        }
        return true;
    }
}
