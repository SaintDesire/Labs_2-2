using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Lab8
{
     public class Flight : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private string departure;
        public string Departure
        {
            get { return departure; }
            set { departure = value; OnPropertyChanged(); }
        }

        private string destination;
        public string Destination
        {
            get { return destination; }
            set { destination = value; OnPropertyChanged(); }
        }

        private string departureTime;
        public string DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; OnPropertyChanged(); }
        }

        private string arrivalTime;
        public string ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; OnPropertyChanged(); }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }
        public byte[] Photo { get; set; } // массив байтов, хранящий изображение в формате varbinary
        public ImageSource PhotoSource
        {
            get
            {
                if (Photo != null && Photo.Length > 0)
                {
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = new MemoryStream(Photo);
                    bitmap.EndInit();
                    return bitmap;
                }
                return null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    }
