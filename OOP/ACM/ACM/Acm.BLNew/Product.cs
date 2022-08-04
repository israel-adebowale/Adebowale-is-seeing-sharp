using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acm.BLNew
{   //a product class which inherits from the entity base class and an interface ILoggable
    public class Product : EntityBase, ILoggable
    {
        //two constructors, where the second defines the product id
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductID = productId;
        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductID { get; private set; }
        private string _productName;
        // a product name property which returns a product name with spaces inserted before the capital letters
        public string ProductName
        {
            get 
            {
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }
        public string Log() => $"{ProductID} {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
