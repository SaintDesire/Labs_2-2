using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private bool _isEnglishSelected;
        public bool IsEnglishSelected
        {
            get { return _isEnglishSelected; }
            set
            {
                _isEnglishSelected = value;
                OnPropertyChanged(nameof(IsEnglishSelected));
            }
        }

        private bool _isRussianSelected;
        public bool IsRussianSelected
        {
            get { return _isRussianSelected; }
            set
            {
                _isRussianSelected = value;
                OnPropertyChanged(nameof(IsRussianSelected));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
