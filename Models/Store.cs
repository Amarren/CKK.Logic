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
        private List<StoreItem> _items = new List<StoreItem>(); //stores "StoreItem" classes

        public Store(int id, string name) //constructor
        {
            _id = id;
            _name = name;
        }

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

        public StoreItem AddStoreItem(Product prod, int quantity) //adds the inputed "StoreItem" or increases the quantity if the "StoreItem" already exists
        {
            var _item = new StoreItem(prod, quantity);

            var result = _items.FirstOrDefault(i => i.GetProduct() == prod);

            if (result == null)
            {
                _items.Add(_item);
                return _item;
            }

            else //adds quantity to the matching item in the list
            {

                if (result.GetProduct() == _item.GetProduct() && quantity > 0)
                {
                    result.SetQuantity(result.GetQuantity() + quantity);
                    return result;
                }
                return null;

            }
        }

        public StoreItem RemoveStoreItem(int id, int quantity) //removes a "StoreItem" with matching product id, amount bassed on the inputed quantity
        {
            var results = _items.FirstOrDefault(i => i.GetProduct().GetId() == id);
            if (results != null)
            {
                if (quantity >= results.GetQuantity()) //if given quantity is greater or equal to the amount in the list set amount to zero
                {
                    results.SetQuantity(0);
                    return results;
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

        public List<StoreItem> GetStoreItems() //returns all "StoreItems" in the list
        {
            return _items;
        }

        public StoreItem FindStoreItemById(int id) //checks if the input id matches any "StoreItem's" product in the list
        {
            var results = _items.FirstOrDefault(i => i.GetProduct().GetId() == id);
            if (results != null) //return "StoreItem" thats product has the matching id
            {
                return results;
            }

            else //returns null due to no matching id
            {
                return null;
            }
        }

    }//end class Store
}//end namespace CKK.Logic.Models
