using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int _id; //stores customer id
        private string _name; //stores customer name
        private string _address; //stores customer address

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

        public string GetAddress() //returns "_address" when "GetAddress" method is called
        {
            return _address;
        }

        public void SetAddress(string address) //sets "_address" = to input address when "SetAddress" method is called
        {
            _address = address;
        }

    }//end class Customer
}//end namespace CKK.Logic.Models
