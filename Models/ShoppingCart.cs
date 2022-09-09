using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer Customer; //stores customer info

        private List<ShoppingCartItem> _products = new List<ShoppingCartItem>(); //product list

        public ShoppingCart(Customer cust) //Constructor
        {
            Customer = cust;
        }

        public int GetCustomerId() //returns customer id
        {
            return Customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity) //adds the inputed "ShoppingCartItem" or increases the quantity if the "ShoppingCartItem" already exists
        {
            var _item = new ShoppingCartItem(prod, quantity);

            var result = _products.FirstOrDefault(i => i.GetProduct() == _item.GetProduct()); //searchs the list to see if the inputed "ShoppingCartItem" already exists in the list

            if (quantity > 0)
            {
                if (result == null) //if no matching "ShoppingCartItem" is found
                {
                    _products.Add(_item);
                    return _item;
                }

                else //if a matching "ShoppingCartItem" is found
                {
                    if (result.GetProduct() == _item.GetProduct())
                    {
                        result.SetQuantity(result.GetQuantity() + quantity); //adds quantity to the matching item in the list
                        return result;
                    }

                    else
                    {
                        return result;
                    }
                }
            }
            else
            {
                return null;
            }

        }

        public ShoppingCartItem RemoveProduct(int id, int quantity) //removes a "ShoppingCartItem" with matching product id, amount bassed on the inputed quantity
        {
            var results = _products.FirstOrDefault(i => i.GetProduct().GetId() == id);
            if (results != null)
            {
                if (quantity >= results.GetQuantity()) //if given quantity is greater or equal to the amount in the list set amount to zero
                {
                    results.SetQuantity(0);
                    var tempResults = results;
                    _products.Remove(results); //removes item from list
                    return tempResults;
                }

                else //subtract given quantity from amount in the list
                {
                    results.SetQuantity(results.GetQuantity() - quantity);
                    return results;
                }
            }
            else //return null if id does not match any item in the list
            {
                return null;
            }
        }
        public ShoppingCartItem GetProductById(int id) //checks if the input id matches any "ShoppingCartItem's" product in the list
        {
            var results = _products.FirstOrDefault(i => i.GetProduct().GetId() == id);
            {
                if (results != null) //return ShoppingCartItem thats product has the matching id
                {
                    return results;
                }

                else //returns null due to no matching id
                {
                    return null;
                }
            }
        }

        public decimal GetTotal() //returns toatl cost of all items in the shopping cart
        {
            decimal total = 0;

            foreach (var item in _products)
            {
                total += item.GetTotal();
            }
            return total;
        }

        public List<ShoppingCartItem> GetProducts() //returns all "ShoppingCartItem's" in the list
        {
            return _products;
        }
    }//end class ShoppingCart
}//end namespace CKK.Logic.Models
