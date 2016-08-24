using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ProductInventory
    {
        Product water = new Product("Water", 1.00);
        Product ojuice = new Product("OJuice", 2.00);
        Product redBull = new Product("Red Bull", 1.50);
        Product pepsi = new Product("Pepsi", 1.00);
        Product coke = new Product("Coke", 1.00);
        Product fanta = new Product("Water", 0.75);
        Product sprite = new Product("Sprite", 1.25);
        Product mDew = new Product("Mountain Dew", 1.50);
        Product rBeer = new Product("Root Beer", 1.25);
        Product milk = new Product("Milk", 3.00);
        Product cMilk = new Product("Chocolate Milk", 3.25);
        Product drPepper = new Product("Dr.Pepper", 1.25);

        int stockLeft = 4;
        int[] stock = new int[5];
        

        public ProductInventory()
        {
            for (int i = 0; i < stock.Length; i++)
            {
                stock[i] = 1;
            }   

        }


        public void ReStock()
        {
            for (int i = 0; i < stock.Length; i++)
            {
                stock[i] = 1;
            }   
        }

        public void RemoveStock()
        {
            if (stockLeft != 0)
            {
                stock[stockLeft] = 0;
                stockLeft--;
            }
        }


        public int checkLeft
        {
            get { return stockLeft; }
        }

    }
}
