public class OutsourcedPart : Part 
{ 
    public string CompanyName { get; set; }
    public OutsourcedPart(int partID, string name, decimal price, int inStock, int min, int max, string companyName, bool belongsToProduct)
        :base(partID, name, price, inStock, min, max, belongsToProduct)
    {
        CompanyName = companyName;
    }

}