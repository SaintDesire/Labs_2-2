using Lab_4_5_Wpf.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5_Wpf.Memento
{
    public class ProductMemento
    {
        public ObservableCollection<Product> Products { get; private set; }

        public ProductMemento(ObservableCollection<Product> Products)
        {
            this.Products = new ObservableCollection<Product>(Products);
        }
    }
}
