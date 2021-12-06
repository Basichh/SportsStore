using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
            .Where(p => p.Product.ProductID == product.ProductID)
            .FirstOrDefault();

            if (line == null)
            {
                
                lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity,
                    Shipping = 3.00,
                    ShownTax = 0.07,
                    Tax = 1.07                    
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        } 
        public virtual void RemoveLine(Product product) =>
            lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);

        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Product.Price * e.Quantity * decimal.Parse(e.Tax.ToString()));

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Shipping { get; set; }
        public double ShownTax { get; set; }
        public double Tax { get; set; }
    }
}