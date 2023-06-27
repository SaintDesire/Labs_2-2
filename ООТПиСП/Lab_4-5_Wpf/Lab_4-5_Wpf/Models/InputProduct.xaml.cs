using Lab_4_5_Wpf.Commands;
using Lab_4_5_Wpf.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_4_5_Wpf.Models
{
    /// <summary>
    /// Логика взаимодействия для InputProduct.xaml
    /// </summary>
    public partial class InputProduct : Window
    {
        private Functions functions;
        private ObservableCollection<Product> Products;
        private string imageUri;
        private int indexSelected;
        private ProductType productType;
        private InputProduct()
        {
            InitializeComponent();
            Type_ComboBox.SelectedIndex = 0;
        }
        public InputProduct(ObservableCollection<Product> Products, Functions functions) : this()
        {
            this.Products = Products;
            this.functions = functions;
        }
        public void AddBinding()
        {
            AddOrChangeButton.Command = this.CommandBindings[1].Command;
        }
        public void ChangeBinding(int index)
        {
            AddOrChangeButton.Command = this.CommandBindings[0].Command;
            indexSelected = index;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
                bool? response = open.ShowDialog();
                if (response.HasValue)
                {
                    if (response.Value == true)
                    {
                        string MEGA_PENIS = open.FileName;
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri(MEGA_PENIS);
                        bi3.EndInit();
                        ProductImage.Stretch = Stretch.Fill;
                        ProductImage.Source = bi3;
                        imageUri = MEGA_PENIS;
                    }
                }
            }
            catch
            {
                MessageBox.Show("error input image");
            }


        }
        private void AddProduct_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (functions.ValidateInputProduct(Title_TextBox.Text, Description_TextBox.Text, imageUri))
                functions.AddToDataGrid(Title_TextBox.Text, Description_TextBox.Text, (int)Price_Slider.Value, imageUri, productType, Products);
            else
                MessageBox.Show("Inpur error. The product has not been added.");
        }

        private void ChangeProductInDataGrid(object sender, ExecutedRoutedEventArgs e)
        {
            if (functions.ValidateInputProduct(Title_TextBox.Text, Description_TextBox.Text, imageUri))
                functions.ChangeInDataGrid(Title_TextBox.Text, Description_TextBox.Text, (int)Price_Slider.Value, imageUri, productType, Products, indexSelected);
            else
                MessageBox.Show("Inpur error. The product has not been added.");
        }

        private void Type_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Type_ComboBox.SelectedIndex == 0)
                productType = ProductType.Ball;
            if (Type_ComboBox.SelectedIndex == 1)
                productType = ProductType.Boots;
        }
    }
}
