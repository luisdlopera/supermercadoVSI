internal class VariablePriceProduct : Product
{
    public string Measurement { get; set; }
    public float Quantity { get; set; }



    public override string ToString()
    {
        return base.ToString() 
            + $"\tMeasurement:{Measurement}\n"
            + $"\tQuantity...: {Quantity}";
    }

    public override decimal ValueToPay()
    {
        throw new NotImplementedException();
    }
}