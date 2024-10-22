using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01_Book
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public Book() { }
        public Book(string name, decimal Price, int Quantity, string Description)
        {
            this.Name = name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Description = Description;
        }
    }
}
