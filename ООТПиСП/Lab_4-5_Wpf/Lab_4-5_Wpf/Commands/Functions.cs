using Lab_4_5_Wpf.Models;
using Lab_4_5_Wpf.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Controls;
using Lab_4_5_Wpf.Memento;

namespace Lab_4_5_Wpf.Commands
{
    public class Functions
    {
        protected internal static MainWindow mainWindow;
        public Functions() { }
        public Functions(MainWindow mainWindow) 
        {
            Functions.mainWindow = mainWindow;
        }
        public void RemoveDataGridItem(ObservableCollection<Product> Products)
        {
            Guid product_id = (mainWindow.ProductsDataGrid.SelectedItem as Product).ID;
            Product product = (from pr in Products where pr.ID == product_id select pr).SingleOrDefault();
            Products.Remove(product);
            mainWindow.ProductsDataGrid.ItemsSource = Products;
        }

        public void OpenProductForm(ObservableCollection<Product> Products, Functions functions)
        {
            InputProduct inputProduct = new InputProduct(Products, functions);
            inputProduct.Owner = mainWindow;
            inputProduct.AddOrChangeButton.Content = "Add";
            inputProduct.AddBinding();
            inputProduct.Show();
        }
        public void ChangeProductForm(ObservableCollection<Product> Products, Functions functions)
        {
            InputProduct inputProduct = new InputProduct(Products, functions);
            inputProduct.Owner = mainWindow;
            inputProduct.AddOrChangeButton.Content = "Change";
            inputProduct.ChangeBinding(mainWindow.ProductsDataGrid.SelectedIndex);
            inputProduct.Title_TextBox.Text = (mainWindow.ProductsDataGrid.SelectedItem as Product).Title;
            inputProduct.Description_TextBox.Text = (mainWindow.ProductsDataGrid.SelectedItem as Product).Description;
            inputProduct.Price_Slider.Value = (mainWindow.ProductsDataGrid.SelectedItem as Product).Price;
            if ((mainWindow.ProductsDataGrid.SelectedItem as Product).Type == ProductType.Ball)
                inputProduct.Type_ComboBox.SelectedIndex = 0;
            if ((mainWindow.ProductsDataGrid.SelectedItem as Product).Type == ProductType.Boots)
                inputProduct.Type_ComboBox.SelectedIndex = 1;
            inputProduct.Show();
        }
        public void AddToDataGrid(string title, string description, int price, string uri, ProductType productType, ObservableCollection<Product> Products)
        {
            Products.Add(new Product(title, description, price, uri, productType));
        }
        public void ChangeInDataGrid(string title, string description, int price, string uri, ProductType productType, ObservableCollection<Product> Products, int selectIndex)
        {
            Products[selectIndex].Title = title;
            Products[selectIndex].Description = description;
            Products[selectIndex].Price = price;
            Products[selectIndex].Image = uri;
            Products[selectIndex].Type = productType;
            mainWindow.ProductsDataGrid.Items.Refresh();
        }
        public bool ValidateInputProduct(string? title, string? description, string? uri)
        {
            if (string.IsNullOrWhiteSpace(title))
                return false;

            if (string.IsNullOrWhiteSpace(description))
                return false;

            if (string.IsNullOrWhiteSpace(uri))
                return false;

            return true;
        }
        public ProductMemento SaveState()
        {
            return new ProductMemento(mainWindow.Products);
        }
        public void RestoreState(ProductMemento memento)
        {
            mainWindow.Products = memento.Products;
            mainWindow.ProductsDataGrid.ItemsSource = mainWindow.Products;
            mainWindow.ProductsDataGrid.Items.Refresh();
        }
    }
}
