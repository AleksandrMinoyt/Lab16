using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab16
{
   public class Products
    {
        private int _code;      
        private string _name;      
        private double _price;

        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Products(int Code, string Name, double Price)
        {
            _code = Code;
            _name = Name;
            _price = Price;
        }  
    }
}
