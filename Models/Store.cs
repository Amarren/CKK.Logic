using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id; //stores "Store" class id
        private string _name; //stores "Store" class name
        private Product _product1; //first product slot
        private Product _product2; //second product slot
        private Product _product3; //third product slot

        public int GetId() //returns "_id" when "GetId" method is called
        {
            return _id;
        }

        public void SetId(int setid) //sets "id" = to input id when "SetId" method is called
        {
            _id = setid;
        }

        public string GetName() //returns "_name" when "GetName" method is called
        {
            return _name;
        }

        public void SetName(string setname) //sets "_name" = to input name when "SetName" method is called
        {
            _name = setname;
        }

        public void AddStoreItem(Product prod) //adds the inputed product to the first available slot
        {
            if (_product1 == null) //test if slot "_product1" is empty
            {
                _product1 = prod;
            }
            
            else if (_product2 == null) //test if slot "_product2" is empty
            {
                _product2 = prod;
            }
            
            else if(_product3 == null) //test if slot "_product3" is empty
            {
                _product3 = prod;
            }
        }

        public void RemoveStoreItem(int productNumber) //removes a product from a slot bassed on the input number
        {
            if (productNumber == 1) //test if input number is 1
            {
                _product1 = null;
            }

            else if (productNumber == 2) //test if input number is 2
            {
                _product2 = null;
            }

            else if (productNumber == 3) //test if input number is 3
            {
                _product3 = null;
            }
        }

        public Product GetStoreItem(int productNumber) //returns the product from a slot bassed on the input number
        {
            if(productNumber == 1) //test if input number is 1
            {
                return _product1;
            }
            
            else if(productNumber == 2) //test if input number is 2
            {
                return _product2;
            }
            
            else if(productNumber == 3) //test if input number is 3
            {
                return _product3;
            }
            
            else //if input is invalid returns null
            {
                return null;
            }
        }

        public Product FindStoreItemById(int id) //checks if the input id matches _product1, _product2, or _product3 in order
        {
            if(_product1.GetId() == id) //test to see if the product in slot "_product1" matches input id
            {
                return _product1;
            }

            else if(_product2.GetId() == id) //test to see if the product in slot "_product2" matches input id
            {
                return _product2;
            }

            else if(_product3.GetId() == id) //test to see if the product in slot "_product3" matches input id
            {
                return _product3;
            }

            else //if none of the products in any of the slots match the input id then returns null
            {
                return null;
            }

        }

    }//end class Store
}//end namespace CKK.Logic.Models
