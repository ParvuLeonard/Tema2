using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class Item
    {
        private Product pr = new Product();

        public Product Pr
        {
            get { return pr; }
            set { pr = value; }
        }

       
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item()
        {

        }

        public Item(Product product, int quantity)
        {
            this.pr = product;
            this.quantity = quantity;
        }
    }
}