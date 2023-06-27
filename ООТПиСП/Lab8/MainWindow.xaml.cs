using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Lab8
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Flight> flights;
        public ObservableCollection<Flight> Flights
        {
            get { return flights; }
            set { flights = value; OnPropertyChanged(); }
        }

        private Flight selectedFlight;
        public Flight SelectedFlight
        {
            get { return selectedFlight; }
            set { selectedFlight = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private readonly string connectionString;

        public MainWindow()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AviaBooking"].ConnectionString;
            Flights = new ObservableCollection<Flight>();
            LoadFlights();
            AddCommand = new RelayCommand(AddFlight);
            UpdateCommand = new RelayCommand(UpdateFlight);
            DeleteCommand = new RelayCommand(DeleteFlight);
            InitializeComponent();
            DataContext = this;
        }
        private void LoadFlights(){
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    var command = new SqlCommand("SELECT Id, Departure, Destination, DepartureTime, ArrivalTime, Price, Photo FROM Flights", connection, transaction);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var flight = new Flight
                            {
                                Id = reader.GetInt32(0),
                                Departure = reader.GetString(1),
                                Destination = reader.GetString(2),
                                DepartureTime = reader.GetString(3),
                                ArrivalTime = reader.GetString(4),
                                Price = reader.GetDecimal(5),
                                Photo = reader["Photo"] as byte[]
                            };
                            Flights.Add(flight);
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("An error occurred while loading flights from the database", ex);
                }
            }
        }

        private void AddFlight()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                var newFlight = new Flight
                {
                    Departure = SelectedFlight.Departure,
                    Destination = SelectedFlight.Destination,
                    DepartureTime = SelectedFlight.DepartureTime,
                    ArrivalTime = SelectedFlight.ArrivalTime,
                    Price = SelectedFlight.Price
                };

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var transaction = connection.BeginTransaction();

                    try
                    {
                        var imagePath = openFileDialog.FileName;
                        var imageBytes = File.ReadAllBytes(imagePath);

                        var query = "INSERT INTO Flights(Departure, Destination, DepartureTime, ArrivalTime, Price, Photo) " +
                                    "VALUES(@departure, @destination, @departureTime, @arrivalTime, @price, @photo);" +
                                    "SELECT SCOPE_IDENTITY();";

                        var command = new SqlCommand(query, connection, transaction);

                        command.Parameters.AddWithValue("@departure", newFlight.Departure);
                        command.Parameters.AddWithValue("@destination", newFlight.Destination);
                        command.Parameters.AddWithValue("@departureTime", newFlight.DepartureTime);
                        command.Parameters.AddWithValue("@arrivalTime", newFlight.ArrivalTime);
                        command.Parameters.AddWithValue("@price", newFlight.Price);
                        command.Parameters.AddWithValue("@photo", imageBytes);

                        var newFlightId = Convert.ToInt32(command.ExecuteScalar());

                        if (newFlightId > 0)
                        {
                            newFlight.Id = newFlightId;
                            newFlight.Photo = imageBytes;
                            flights.Add(newFlight);
                        }


                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error adding flight: {ex.Message}");
                    }
                }
            }
        }






        private void UpdateFlight()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                var command = new SqlCommand("UPDATE Flights SET Departure=@Departure, Destination=@Destination, DepartureTime=@DepartureTime, ArrivalTime=@ArrivalTime, Price=@Price WHERE Id=@Id", connection, transaction);
                command.Parameters.AddWithValue("@Departure", SelectedFlight.Departure);
                command.Parameters.AddWithValue("@Destination", SelectedFlight.Destination);
                command.Parameters.AddWithValue("@DepartureTime", SelectedFlight.DepartureTime);
                command.Parameters.AddWithValue("@ArrivalTime", SelectedFlight.ArrivalTime);
                command.Parameters.AddWithValue("@Price", SelectedFlight.Price);
                command.Parameters.AddWithValue("@Id", SelectedFlight.Id);
                try
                {
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error updating flight: {ex.Message}");
                }
            }
        }

        private void DeleteFlight()
        {
            if (SelectedFlight == null)
            {
                return;
            }

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var transaction = connection.BeginTransaction();

                try
                {
                    var deleteCommand = new SqlCommand("DELETE FROM Flights WHERE Id=@Id", connection, transaction);
                    deleteCommand.Parameters.AddWithValue("@Id", SelectedFlight.Id);

                    var rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        Flights.Remove(SelectedFlight);
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error deleting flight: {ex.Message}");
                }
            }
        }
        private void sortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sortProperty = (sortComboBox.SelectedItem as ComboBoxItem)?.Tag.ToString();

            if (sortProperty == null)
            {
                return;
            }

            var selectedItem = (ComboBoxItem)e.AddedItems[0];
            var sortDirectionString = selectedItem.Content.ToString();

            var view = CollectionViewSource.GetDefaultView(Flights);
            view.SortDescriptions.Clear();

            if (sortDirectionString.Contains("убыв"))
            {
                view.SortDescriptions.Add(new SortDescription(sortProperty, ListSortDirection.Descending));
            }
            else
            {
                view.SortDescriptions.Add(new SortDescription(sortProperty, ListSortDirection.Ascending));
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void flightsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (flightsDataGrid.SelectedItem is Flight selectedFlight)
            {
                SelectedFlight = selectedFlight;
            }
        }


    }

    public class ByteArrayToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is byte[]))
            {
                return null;
            }
            var bytes = value as byte[];
            var image = new BitmapImage();
            using (var stream = new MemoryStream(bytes))
            {
                stream.Position = 0;
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = stream;
                image.EndInit();
            }
            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

    }
}
