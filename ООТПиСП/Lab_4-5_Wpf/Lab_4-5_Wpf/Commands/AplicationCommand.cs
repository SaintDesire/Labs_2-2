using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab_4_5_Wpf.Commands
{
    public class AplicationCommand
    {
        private static RoutedUICommand addCommand =
            new RoutedUICommand("ADD", "ADD", typeof(AplicationCommand));
        public static RoutedUICommand AddCommand
        {
            get { return addCommand; }
        }

        private static RoutedUICommand removeCommand =
            new RoutedUICommand("remove", "remove", typeof(AplicationCommand));
        public static RoutedUICommand RemoveCommand
        {
            get { return removeCommand; }
        }
        private static RoutedUICommand changeCommand =
            new RoutedUICommand("addProductToData", "addProductToData", typeof(AplicationCommand));
        public static RoutedUICommand ChangeCommand
        {
            get { return changeCommand; }
        }
        //--------------------------------------------
        private static RoutedUICommand addProductToDataGridCommand =
            new RoutedUICommand("addProductToData", "addProductToData", typeof(AplicationCommand));
        public static RoutedUICommand AddProductToDataGrid
        {
            get { return addProductToDataGridCommand; }
        }
        private static RoutedUICommand changeProductInDataGridCommand =
            new RoutedUICommand("addProductToData", "addProductToData", typeof(AplicationCommand));
        public static RoutedUICommand ChangeProductInDataGridCommand
        {
            get { return changeProductInDataGridCommand; }
        }
        //--------------------userControl
        private static RoutedUICommand saveStateCommand =
            new RoutedUICommand("addProductToData", "addProductToData", typeof(AplicationCommand));
        public static RoutedUICommand SaveStateCommand
        {
            get { return saveStateCommand; }
        }
        private static RoutedUICommand restoreStateCommand =
            new RoutedUICommand("addProductToData", "addProductToData", typeof(AplicationCommand));
        public static RoutedUICommand RestoreStateCommand
        {
            get { return restoreStateCommand; }
        }
    }
}
