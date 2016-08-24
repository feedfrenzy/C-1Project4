using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Product
    {

        string name = "";
        double price = 0;

        public Product()
        {
            name = "";
            price = 0;
        }

        public Product(string pName, double pPrice)
        {
            name = pName;
            price = pPrice;
        }

        public double getPrice
        {
            get { return price; }
            set { price = value; }
        }

        public string getName
        {
            get { return name; }
            set { name = value; }
        }


        public double total
        {
            set { price += value; }
        }

    }
}
