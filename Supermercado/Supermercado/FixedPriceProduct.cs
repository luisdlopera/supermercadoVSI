public class FixedPriceProduct : Product
{


    public override string ToString()
    {
        return base.ToString();
    }

    public override decimal ValueToPay()
    {
        throw new NotImplementedException();
    }
}