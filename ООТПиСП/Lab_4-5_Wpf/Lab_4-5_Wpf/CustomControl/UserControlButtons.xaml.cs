using Lab_4_5_Wpf.Commands;
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

namespace Lab_4_5_Wpf.CustomControl
{
    /// <summary>
    /// Логика взаимодействия для UserControlButtons.xaml
    /// </summary>
    public partial class UserControlButtons : UserControl
    {
        private Functions functions;
        public UserControlButtons()
        {
            InitializeComponent();
            functions = new Functions();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("penis1");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("penis1");
        }

        private void RedoState(object sender, ExecutedRoutedEventArgs e)
        {
            if (Functions.mainWindow.caretaker.UndoHistory.Count == 0)
                MessageBox.Show("Stack empty!");
            else
                functions.RestoreState(Functions.mainWindow.caretaker.UndoHistory.Pop());
        }
    }
}
