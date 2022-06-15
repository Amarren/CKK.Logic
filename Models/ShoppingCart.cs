using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private static Product _emptySlot = new();

        private Customer Customer; //stores customer info
        private ShoppingCartItem Product1 = new(_emptySlot, 0); //first product slot
        private ShoppingCartItem Product2 = new(_emptySlot, 0); //second product slot
        private ShoppingCartItem Product3 = new(_emptySlot, 0); //third product slot 

        public ShoppingCart(Customer cust) //Constructor
        {
            Customer = cust;
        }

        public int GetCustomerid() //returns customer id
        {
            return Customer.GetId();  
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity) //adds a product to the first slot that matches the inputed product or to the first empty slot if no slot matches
        {
            if (quantity > 0) //check if inputed quantity is greater than 0
            {
                //check to see if inputed product already exists in a slot
                if (prod == Product1.GetProduct()) //check if inputed product is already in slot "Product1" 
                {
                    Product1.SetQuantity(Product1.GetQuantity() + quantity); //adds inputed quantity to the existing quntity of "Product1"
                    return Product1;
                }

                else if (prod == Product2.GetProduct()) //check if inputed product is already in slot "Product2" 
                {
                    Product2.SetQuantity(Product2.GetQuantity() + quantity); //adds inputed quantity to the existing quntity of "Product2"
                    return Product2;
                }

                else if (prod == Product3.GetProduct()) //check if inputed product is already in slot "Product3" 
                {
                    Product3.SetQuantity(Product3.GetQuantity() + quantity); //adds inputed quantity to the existing quntity of "Product3"
                    return Product3;
                }

                //input product into the first available slot
                else if (Product1.GetProduct() == _emptySlot) //check if slot "Product1" is empty
                {
                    Product1.SetProduct(prod); //adds inputed product to slot "Product1"
                    Product1.SetQuantity(quantity); //adds inputed quantity to slot "Product1"
                    return Product1;
                }

                else if (Product2.GetProduct() == _emptySlot) //check if slot "Product2" is empty
                {
                    Product2.SetProduct(prod); //adds inputed product to slot "Product2"
                    Product2.SetQuantity(quantity); //adds inputed quantity to slot "Product2"
                    return Product2;
                }

                else if (Product3.GetProduct() == _emptySlot) //check if slot "Product3" is empty
                {
                    Product3.SetProduct(prod); //adds inputed product to slot "Product3"
                    Product3.SetQuantity(quantity); //adds inputed quantity to slot "Product3"
                    return Product3;
                }

                else //returns null if all slots are filled with other products
                {
                    return null;
                }
            }

            else //returns null if the quantity input is invalid
            {
                return null;
            }
        }

        public ShoppingCartItem AddProduct(Product prod) //runs the first "AddProduct" method with a quantity of 1
        {
            return AddProduct(prod, 1);
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (prod == Product1.GetProduct()) //checks if inputed product matches "Product1"
            {
                if (quantity <= Product1.GetQuantity()) //checks if inputed quantity is less than or equal to "Product1" quantity
                {
                    Product1.SetQuantity(Product1.GetQuantity() - quantity); //reduce quantity of "Product1" by inputed quantity
                    return Product1;
                }

                else
                {
                    return null; //returns null if inputed quantity is greater than "Product1" quantity
                }
            }

            else if (prod == Product2.GetProduct()) //checks if inputed product matches "Product2"
            {
                if (quantity <= Product2.GetQuantity()) //checks if inputed quantity is less than or equal to "Product2" quantity
                {
                    Product2.SetQuantity(Product2.GetQuantity() - quantity); //reduce quantity of "Product2" by inputed quantity
                    return Product2;
                }

                else
                {
                    return null; //returns null if inputed quantity is greater than "Product2" quantity
                }
            }

            else if (prod == Product3.GetProduct()) //checks if inputed product matches "Product3"
            {
                if (quantity <= Product3.GetQuantity()) //checks if inputed quantity is less than or equal to "Product3" quantity
                {
                    Product3.SetQuantity(Product3.GetQuantity() - quantity); //reduce quantity of "Product3" by inputed quantity
                    return Product3;
                }

                else
                {
                    return null; //returns null if inputed quantity is greater than "Product3" quantity
                }
            }

            else
            {
                return null; //returns null if inputed product does not match any products in the slots "Product1, Product2, or Product3"
            }
        }
        public ShoppingCartItem GetProductById(int id) //returns the product that matches the inputed id
        {
            if (id == Product1.GetId()) //check if the inputed id matches "Product1"
            {
                return Product1;
            }

            else if (id == Product2.GetId()) //check if the inputed id matches "Product2"
            {
                return Product2;
            }

            else if (id == Product3.GetId()) //check if the inputed id matches "Product3"
            {
                return Product3;
            }

            else
            {
                return null; //returns null if the inputed id does not match any products
            }
        }

        public decimal GetTotal() //returns toatl cost of all items in the shopping cart
        {
            return Product1.GetTotal() + Product2.GetTotal() + Product3.GetTotal();
        }

        public ShoppingCartItem GetProduct(int Num) //returns the product from the inputed numbered slot
        {
            switch (Num)
            {
                case 1:
                    return Product1;

                case 2:
                    return Product2;

                case 3:
                    return Product3;

                default:
                    return null; //returns null if an invalid input is given

            }
        }

    }//end class ShoppingCart
}//end namespace CKK.Logic.Models
