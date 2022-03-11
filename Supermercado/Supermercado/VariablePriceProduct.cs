using Supermercado;

public class VariablePriceProduct : Product
{
    public VariablePriceProduct(string Description, int Id, double Price, double Tax) : base(Description, Id, Price, Tax)
    {
    }

    public string Description { get; set; }
    public int Id { get; set; }
    public string Measurement { get; set; }
    public decimal Price { get; set; }
    public float Quantity { get; set; }
    public float Tax { get; set; }
}