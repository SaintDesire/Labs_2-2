    using Lab_4_5.Products;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
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
    using Application = System.Windows.Application;

    namespace Lab_4_5
    {
        public partial class MainWindow : Window
        {

            public Localization loc;

            public ObservableCollection<Product> Products = new ObservableCollection<Product>();

            public static RoutedUICommand DeleteProductCommand = new RoutedUICommand("Delete Product", "DeleteProduct", typeof(MainWindow));

            public static RoutedUICommand AddProductCommand = new RoutedUICommand("Add Product", "AddProduct", typeof(MainWindow));

            public static RoutedUICommand ChangeProductCommand = new RoutedUICommand("Change Product", "ChangeProduct", typeof(MainWindow));

            private MyViewModel _viewModel;

            private Stack<Action> undoStack = new Stack<Action>();
            private Stack<Action> redoStack = new Stack<Action>();



            public MainWindow()
            {
                InitializeComponent();

                CommandBindings.Add(new CommandBinding(DeleteProductCommand, DeleteProduct_Executed));
                CommandBindings.Add(new CommandBinding(ChangeProductCommand, EditProduct_Executed));
                CommandBindings.Add(new CommandBinding(AddProductCommand, AddProduct_Executed));

                loc = new Localization();

                _viewModel = new MyViewModel();
                DataContext = _viewModel;
                _viewModel.IsRussianSelected = true;
                _viewModel.IsEnglishSelected = false;
                
                
                doButtons.UndoRequested += CustomButton_UndoRequested;
                doButtons.RedoRequested += CustomButton_RedoRequested;
            }
            private void CustomButton_UndoRequested(object sender, EventArgs e)
            {
                UndoState(sender);
            }

            private void CustomButton_RedoRequested(object sender, EventArgs e)
            {
                RedoState(sender);
            }

            private void SetEng_Executed(object sender, RoutedEventArgs e)
            {
                _viewModel.IsEnglishSelected = true;
                _viewModel.IsRussianSelected = false;
                loc.SetLang("Eng");
            }

            private void SetRu_Executed(object sender, RoutedEventArgs e)
            {
                _viewModel.IsEnglishSelected = false;
                _viewModel.IsRussianSelected = true;
                loc.SetLang("Rus");
            }

            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                Products.Add(new Product("Долина Йосемити, США", "Живописная долина Йосемити с горами и рекой Мерсед в солнечный день в национальном парке Йосемити", 75, "Img/Meteora.jpg"));
                Products.Add(new Product("Цветные скалы Чжанъе Данксиа, Китай", "Геологический парк в китайской провинции Ганьсу известен необычным природным сокровищем — красочными горными образованиями из разноцветных пород песчаника и конгломератов, относящихся преимущественно к Меловому периоду. Около сотни миллионов лет назад на месте гор был природный бассейн, который позже высох, а его осадок окислился, приняв необычайно красивую пёструю расцветку.", 100, "Img/Zhangye-Danxia.jpg"));
                Products.Add(new Product("Бамбуковый лес, Япония", "В сердце городских ландшафтов Киото расположился живописный уголок природы — густая бамбуковая роща, состоящая из бесчисленного количества бамбуковых деревьев. На внушительной площади есть где разгуляться, поэтому лес стал излюбленным местом отдыха горожан и приезжих. В темное время суток парк подсвечивается сотнями маленьких фонариков и завораживает своим сказочным видом.", 200, "Img/Sagano-bamboo.jpg"));
                Products.Add(new Product("Монастырский комплекс Метеоры, Греция", "Уникальные монастыри буквально вырастают из горной породы, венчая вершины скал. Сами скалы являются частью древней горной системы Фессалии, расположенной в историческом регионе Греции. Около 60 млн лет назад на месте скал располагалось море, а сегодня Метеоры является одним из самых ценных и священных исторических мест, с точки зрения христианской религии.", 170, "Img/Meteora.jpg"));
                Products.Add(new Product("Салар де Юни, Боливия", "На юге высокогорной пустыни, на плато Альтипано, когда-то находилось солёное озеро. Позже оно пересохло, оголив солёное дно. Толщина пласта соли составляет от 2 до 8 метров, и в сезон дождей, когда поверхность этого пласта покрывает слой воды, солончак Юни становится подобным гигантскому зеркалу: гладь озера сливается с синевой неба, и окружающие ландшафты обретают поистине неземную красоту.", 250, "Img/Salar-de-Uyuni.jpg"));
                Products.Add(new Product("Горы Тяньцзи, Китай", "Задавшись вопросом, какое самое красивое место на земле, многие путешественники делают выбор в пользу одного из природных парков Китая — Чжанцзяцзе. На его территории располагаются «парящие» горы. Именно эти пейзажи стали прототипом ландшафтов во всемирно известной картине «Аватар». Овеянные туманом горные пики на фоне зелёной бездны производят поистине потрясающее впечатление.", 290, "Img/Tianzi-Mountains.jpg"));
                LViewProducts.ItemsSource = Products;
            }

        //private void FilterProducts_Executed(object sender, TextChangedEventArgs e)
        //{
        //    ObservableCollection<Product> newProducts = new ObservableCollection<Product>();

        //    var filteredProducts = Products.Where(p => p.Title.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
        //    newProducts = new ObservableCollection<Product>(filteredProducts);

        //    LViewProducts.ItemsSource = newProducts;
        //}

        private void EditProduct_Executed(object sender, RoutedEventArgs e)
            {
                var selectedProduct = LViewProducts.SelectedItem as Product;
                int index = Products.IndexOf(selectedProduct);
                if (selectedProduct != null)
                {
                    EditPage edit = new EditPage(selectedProduct.Title, selectedProduct.Description, selectedProduct.Price, selectedProduct.Image, selectedProduct.ID);
                    edit.Show();
                }

                undoStack.Push(() => Products[index] = selectedProduct);
                redoStack.Clear();
            }

            private void DeleteProduct_Executed(object sender, RoutedEventArgs e)
            {
                var selectedProduct = LViewProducts.SelectedItem as Product;
                int index = Products.IndexOf(selectedProduct);
                if (selectedProduct != null)
                {
                    Products.Remove(selectedProduct);
                }
                LViewProducts.Items.Refresh();

                undoStack.Push(() => Products[index] = selectedProduct);
                redoStack.Clear();
            }

            private void AddProduct_Executed(object sender, RoutedEventArgs e)
            {
                AddPage add = new AddPage();
                add.Show();
            }

            public void AddProduct(Product product)
            {
                Products.Add(product);
                int index = Products.IndexOf(product);
                undoStack.Push(() => Products[index] = product);
                redoStack.Clear();
            }
            public void EditProduct(string title, string description, int price, string image, Guid id)
            {
                // Находим элемент в коллекции products с совпадающим title
                Product productToUpdate = Products.FirstOrDefault(p => p.ID == id);
                if (productToUpdate != null)
                {
                    // Изменяем данные товара
                    productToUpdate.Title = title;
                    productToUpdate.Description = description;
                    productToUpdate.Price = price;
                    productToUpdate.Image = image;
                    LViewProducts.Items.Refresh();
                }
                else
                {
                    // Если элемент не найден, выводим сообщение об ошибке
                    MessageBox.Show($"Товар с названием \"{title}\" не найден.");
                }
            }

            private void UndoState(object sender)
            {
                if (undoStack.Count > 0)
                {
                    // Извлеките последнее действие из UndoStack, выполните его и добавьте его в RedoStack.
                    Action undoAction = undoStack.Pop();
                    undoAction();
                    redoStack.Push(undoAction);

                    // Обновите ListView.
                    LViewProducts.Items.Refresh();
                }
            }

            private void RedoState(object sender)
            {
                if (redoStack.Count > 0)
                {
                    // Извлеките последнее действие из RedoStack, выполните его и добавьте его в UndoStack.
                    Action redoAction = redoStack.Pop();
                    redoAction();
                    undoStack.Push(redoAction);

                    // Обновите ListView.
                    LViewProducts.Items.Refresh();
                }
            }


            private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)sortComboBox.SelectedItem;

                if (selectedItem.Content.ToString() == "По возрастанию цены")
                {
                    Products = new ObservableCollection<Product>(Products.OrderBy(p => p.Price));
                    LViewProducts.ItemsSource = Products;
                }
                else if (selectedItem.Content.ToString() == "По убыванию цены")
                {
                    Products = new ObservableCollection<Product>(Products.OrderByDescending(p => p.Price));
                    LViewProducts.ItemsSource = Products;         
                }
            }


            public void SwitchThemeNormal(object sender, RoutedEventArgs e)
            {
                // загрузка словаря ресурсов Normal из файла Dictionary1.xaml
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri("Dictionaries/Dictionary1.xaml", UriKind.RelativeOrAbsolute);

                // добавление словаря ресурсов в ресурсы текущего окна
                this.Resources.MergedDictionaries.Clear();
                this.Resources.MergedDictionaries.Add(dict);
            }

            public void SwitchThemeBlack(object sender, RoutedEventArgs e)
            {
                // загрузка словаря ресурсов Normal из файла Dictionary1.xaml
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri("Dictionaries/Dictionary2.xaml", UriKind.RelativeOrAbsolute);

                // добавление словаря ресурсов в ресурсы текущего окна
                this.Resources.MergedDictionaries.Clear();
                this.Resources.MergedDictionaries.Add(dict);
            }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked (Direct)");
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("StackPanel clicked (Bubbling)");
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("StackPanel clicked (Tunneling)");
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("TextBlock clicked (Bubbling)");
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("TextBlock clicked (Tunneling)");
        }
    }
    }
