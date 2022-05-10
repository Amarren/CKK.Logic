using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class StoreItem
    {
        private Product _product; //stores product
        private int _quantity; //stores quantity of product

        public StoreItem(Product product, int quantity) //constructor for "StoreItem" class
        {
            _product = product;
            _quantity = quantity;
        }

        public int GetQuantity() //returns "_quanttity" when "GetQuantity" method is called
        {
            return _quantity;
        }

        public void SetQuantity(int quantity) //sets "_quantity" = to input quantity when "SetQuantity" method is called
        {
            _quantity = quantity;
        }

        public Product GetProduct() //returns "_product" when "GetProduct" method is called
        {
            return _product;
        }

        public void SetProduct(Product product) //sets "_product" = to input product when "SetProduct" method is called
        {
            _product = product;
        }

    }//end class StoreItem
}//end namespace CKK.Logic.Models
