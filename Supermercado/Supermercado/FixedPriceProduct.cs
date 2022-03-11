using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class FixedPriceProduct : Product
    {
      

        public FixedPriceProduct(string Description, int Id, double Price, double Tax) : base(Description, Id, Price, Tax)
        {


        }
    }
}
