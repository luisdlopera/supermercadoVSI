using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public abstract class Product
    {
        public string _Description;
        public int _Id;
        public double _Price;
        public double _Tax;

        public Product(string Description, int Id, double Price, double Tax)
        {
            _Description   = Description;
            _Id = Id;       
            _Price = Price;
            _Tax = Tax;

        }
        
        public String toString()
        {
            return $" La descripcion es:{ }";
        }

    }
}
