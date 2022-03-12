public abstract class Product : Supermercado.IPay
{
    public string Description { get; set; }
    public int Id { get; set; }
    public decimal Price { get; set; }
    public float Tax { get; set; }


    public override string ToString()
    {
        return $" {Id} - {Description}\n" +
               $" \tPrice......:{Price} \n " +
               $" \tTax........:{Tax} \n";
    }

    public abstract decimal ValueToPay();
    

}