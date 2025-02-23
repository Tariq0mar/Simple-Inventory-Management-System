
using System;

namespace ISimpleInventoryManagementSystem
{
    public class Product
    {
        private string _name;
        private float _price;
        private int _quantity;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Product(string name, float price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }
    }
}
