using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int setid)
        {
            _id = setid;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string setname)
        {
            _name = setname;
        }

        public void AddStoreItem(Product prod)
        {
            if (_product1 == null)
            {
                _product1 = prod;
            }
            
            else if (_product2 == null)
            {
                _product2 = prod;
            }
            
            else if(_product3 == null)
            {
                _product3 = prod;
            }
        }

        public void RemoveStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                _product1 = null;
            }

            else if (productNumber == 2)
            {
                _product2 = null;
            }

            else if (productNumber == 3)
            {
                _product3 = null;
            }
        }

        public Product GetStoreItem(int productNumber)
        {
            if(productNumber == 1)
            {
                return _product1;
            }
            
            else if(productNumber == 2)
            {
                return _product2;
            }
            
            else if(productNumber == 3)
            {
                return _product3;
            }
            
            else
            {
                return null;
            }
        }

        public Product FindStoreItemById(int id)
        {
            if(_product1.GetId() == id)
            {
                return _product1;
            }

            else if(_product2.GetId() == id)
            {
                return _product2;
            }

            else if(_product3.GetId() == id)
            {
                return _product3;
            }

            else
            {
                return null;
            }

        }


    }
}
