using Supermercado;

internal class ComposedProduct : Product
{
    public string Description { get; set; }
    public float Discount { get; set; }
    public int Id { get; set; }
    public List<Product> Products { get; set; }
}