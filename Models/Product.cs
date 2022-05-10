using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int _id; //stores product id
        private string _name; //stores product name
        private decimal _price; //stores product price

        public int GetId() //returns "_id" when "GetId" method is called
        {
            return _id;
        }

        public void SetId(int id) //sets "_id" = to input id when "SetId" method is called
        {
            _id = id;
        }

        public string GetName() //returns "_name" when "GetName" method is called
        {
            return _name;
        }

        public void SetName(string name) //sets "_name" = to input name when "SetName" method is called
        {
            _name = name;
        }

        public decimal GetPrice() //returns "_price" when "GetPrice" method is called
        {
            return _price;
        }

        public void SetPrice(decimal price) //sets "_price" = to input price when "SetPrice" method is called
        {
            _price = price;
        }

    }//end class Product
}//end namespace CKK.Logic.Models
