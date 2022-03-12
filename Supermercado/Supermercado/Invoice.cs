using Supermercado;

public class Invoice :IPay

{
    private Product _products;

    public override string ToString()
    {
        return base.ToString();
    }
    public void AddProduct(Product product) {
        Console.WriteLine(product);
        
    }

    public decimal ValueToPay()
    {
        throw new NotImplementedException();
    }

    


}