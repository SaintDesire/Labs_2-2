using Lab_4_5_Wpf.Commands;
using Lab_4_5_Wpf.Memento;
using Lab_4_5_Wpf.Models;
using Lab_4_5_Wpf.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Application;

namespace Lab_4_5_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected internal ObservableCollection<Product> Products = new ObservableCollection<Product>();
        private Functions functions;
        protected internal Caretaker caretaker;
        public MainWindow()
        {
            InitializeComponent();
            functions = new Functions(this);
            caretaker = new Caretaker();

            List<string> styles = new List<string> { "DarkBorderTheme", "PinkBorderTheme" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "DarkBorderTheme";
        }
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            WindowBorder.Style = (Style)Application.Current.FindResource(style);

        }
        private void ProductsDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DescriptionColumn.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Description"];
            ID_Title_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_ID_Title"];
            Price_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Price"];
            Type_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Type"];
            Operations_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Operations"];

            Products.Add(new Product("Adidas Predator Freak.1", "Adidas Predator Freak.1 FG/бутсы профессиональные", 100, "/Images/adidas_predator.jpg", ProductType.Boots));
            Products.Add(new Product("Adidas Predator Mutator", "Бутсы Adidas Predator Mutator 20+ FG", 200, "/Images/adidas_predator_19pink.jpg", ProductType.Boots));
            Products.Add(new Product("Adidas Predator Freak.1", "Бутсы футбольные Adidas Predator Freak. 1 FG", 165, "/Images/adidas_predator_freak.jpg", ProductType.Boots));
            Products.Add(new Product("Мяч Al Rihla", "Мяч футбольный 5 Adidas WC22 Al Rihla PRO OMB", 120, "/Images/AL_RIHLA.jpg", ProductType.Ball));
            ProductsDataGrid.ItemsSource = Products;
        }
        private void RemoveDataGridItem(object sender, ExecutedRoutedEventArgs e)
        {
            caretaker.UndoHistory.Push(functions.SaveState());
            functions.RemoveDataGridItem(Products);
        }
        private void AddProductInputForm_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            caretaker.UndoHistory.Push(functions.SaveState());
            functions.OpenProductForm(Products, functions);
        }
        private void ChangeDataGridItem(object sender, ExecutedRoutedEventArgs e)
        {
            caretaker.UndoHistory.Push(functions.SaveState());
            functions.ChangeProductForm(Products, functions);
        }
        private void CloseForm_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Product> lstPr = new List<Product>();
            foreach (Product pr in Products)
                lstPr.Add(pr);
            using (FileStream file = new FileStream("ProductsData.json", FileMode.Create))
            {
                JsonSerializer.Serialize<List<Product>>(file, lstPr);
            }
            this.Close();
        }

        private void EnglishRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).loc.SetLang("Eng");
            DescriptionColumn.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Description"];
            ID_Title_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_ID_Title"];
            Price_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Price"];
            Type_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Type"];
            Operations_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Operations"];
        }

        private void RussianRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).loc.SetLang("Rus");
            DescriptionColumn.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Description"];
            ID_Title_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_ID_Title"];
            Price_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Price"];
            Type_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Type"];
            Operations_Column.Header = ((App)Application.Current).loc.application.Resources["Loc_DataGridColumn_Operations"];
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                ProductsDataGrid.ItemsSource = Products;
            }
            else
            {
                List<Product> lstPr = new List<Product>();
                foreach (Product pr in Products)
                    lstPr.Add(pr);
                var listItog = from p in lstPr
                               where p.Title.Contains(SearchBox.Text)
                               select p;
                ObservableCollection<Product> SearchedProducts = new ObservableCollection<Product>();
                foreach(Product p in listItog)
                    SearchedProducts.Add(p);
                ProductsDataGrid.ItemsSource = SearchedProducts;
            }
        }
    }
}
