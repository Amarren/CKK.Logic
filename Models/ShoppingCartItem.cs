using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _product; //stores the product in the shopping cart
        private int _quantity; //stores the quantity of the product in the shopping cart

        public ShoppingCartItem(Product product, int quantity) //constructor for "ShoppingCartItem" class
        {
            _product = product;
            _quantity = quantity;
        }

        public int GetQuantity() //returns "_quantity" when "GetQuantity" method is called
        {
            return _quantity;
        }

        public void SetQuantity(int quantity) //sets "_quantity" = to input when "SetQuantity" method is called
        {
            _quantity = quantity;
        }

        public Product GetProduct() //returns "_product" when "GetProduct" method is called
        {
            return _product;
        }

        public void SetProduct(Product product) //sets "_product" = to input when "Setproduct" method is called
        {
            _product = product;
        }

        public decimal GetTotal() //returns total value of "_product.GetPrice()" multiplied by "_quantity"
        {
            return _product.GetPrice() * Convert.ToDecimal(_quantity);
        }

    }//end class ShoppingCartItem
}//end namespace CKK.Logic.Models
