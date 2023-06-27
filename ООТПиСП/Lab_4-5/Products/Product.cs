using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5.Products
{
    public class Product
    {
        private string _title;
        private string _description;
        private int _price;
        private string _image;

        private Guid _id;
        public Guid ID { get { return _id; } set { _id = value; } }


        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public string Image { get { return _image; } set { _image = value; } }
        public Product()
        {
            _id = Guid.NewGuid();
        }
        public Product(string Title, string Description, int Price, string Image) : this()
        {
            this.Title = Title;
            this.Description = Description;
            this.Price = Price;
            this.Image = Image;
        }
        public Product(string Title, string Description, int Price) : this()
        {
            this.Title = Title;
            this.Description = Description;
            this.Price = Price;
        }
    }
}
