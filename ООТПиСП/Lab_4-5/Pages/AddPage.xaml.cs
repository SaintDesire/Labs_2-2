using Lab_4_5.Products;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_4_5
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Window
    {
        private string _title;
        private string _description;
        private int _price;
        private string _image;

        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public string Image { get { return _image; } set { _image = value; } }
        public AddPage()
        {
            InitializeComponent();
        }

        private void ChooseImageButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (dialog.ShowDialog() == true)
            {
                string imagePath = dialog.FileName;
                Image = imagePath;
                // используйте выбранный imagePath для загрузки изображения
                productImage.Source = new BitmapImage(new Uri(imagePath));
                productImage.Visibility = Visibility.Visible;
            }
        }

        private void descriptionField_TextChanged(object sender, TextChangedEventArgs e)
        {
            Description = descriptionField.Text;
        }


        private void ValidateData(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            if (string.IsNullOrEmpty(Title))
            {
                MessageBox.Show("Введите название товара");
                return;
            }

            if (string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Введите описание товара");
                return;
            }

            if (Price <= 0)
            {
                MessageBox.Show("Введите цену товара > 0");
                return;
            }

            if (string.IsNullOrEmpty(Image))
            {
                MessageBox.Show("Вставьте изображение");
                return;
            }

            mainWindow.AddProduct(new Product(Title, Description, Price, Image));

            this.Close();
        }
    }
}
