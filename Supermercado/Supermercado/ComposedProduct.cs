
internal class ComposedProduct : Product
{
    public float Discount { get; set; }
    public List<Product>? Products { get; set; }





    public override string ToString()
    {
        string acomulador = "";
        
        foreach (Product p in Products)
        {
            acomulador += p.Description+"," ;
        }


        return $" {Id} - {Description}"+
                $"\n\tProducts...:{acomulador}\n" +
                $"\tDiscount...:{$"{Discount*100}%" }"; 
    }



    public override decimal ValueToPay()
    {
        throw new NotImplementedException();
    }
}