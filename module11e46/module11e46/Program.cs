using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmer : Kairi Tabajen

// Create the Product class which implement something similar to a Point of Sale
//app:
//• Name – string property for the Name of a product
// Quantity – integer property for the quantity of product
//• Unit – string property (ex: sachet, pc, box, pouch, bar)
//• Price – double property for price of the product
//• Amount – a read only property which returns Quantity * Price

namespace module11e46
{
    class Product
    {
        public string pName;//• Name – string property for the Name of a product
        public int qnt;// Quantity – integer property for the quantity of product
        public double price;//• Price – double property for price of the product
        private string unit;//• Unit – string property (ex: sachet, pc, box, pouch, bar)

        public Product(string PName, int Qnt, string Unit, double Price)
        {
            pName = PName;
            qnt = Qnt;
            price = Price;
            Unit1 = Unit;
        }
        public string Unit1
        {
            get { return unit; }
            set { 
                if (value == "sachet" ||value == "pc" ||value == "box" ||value == "pouch" ||value == "bar")
                {
                    unit = value;
                }
                else
                {
                    unit = "unknown";
                }
            }

        }
       
 }
     class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product("Ariel", 2, "sachet", 7.50);

             Console.WriteLine("*************************");
            Console.WriteLine("Item: " + product1.pName);
            Console.WriteLine("Quantity: " + product1.qnt);
            Console.WriteLine("Price: " + product1.price);
            Console.WriteLine("Unit: " + product1.Unit1);
            Console.WriteLine("Amount: " + product1.qnt * product1.price);//• Amount – a read only property which returns Quantity * Price
            Console.WriteLine("*************************");
            Product product = new Product("Tide", 2, "sachet", 30);

            Console.WriteLine("Item: " + product.pName);
            Console.WriteLine("Quantity: " + product.qnt);
            Console.WriteLine("Price: " + product.price);
            Console.WriteLine("Unit: " + product.Unit1);
            Console.WriteLine("Amount: " + product.qnt * product.price);//• Amount – a read only property which returns Quantity * Price
            Console.WriteLine("*************************");


            Console.ReadLine();
        }

    }
}
