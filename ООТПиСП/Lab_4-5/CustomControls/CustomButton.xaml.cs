using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab_4_5
{
    public partial class CustomButton : UserControl
    {

        public event EventHandler UndoRequested;
        public event EventHandler RedoRequested;

        public CustomButton()
        {
            InitializeComponent();
        }

        private void OnUndoRequested(object sender, EventArgs e)
        {
            UndoRequested?.Invoke(this, e);
        }

        private void OnRedoRequested(object sender, EventArgs e)
        {
            RedoRequested?.Invoke(this, e);
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            OnUndoRequested(this, EventArgs.Empty);
        }

        private void RedoButton_Click(object sender, RoutedEventArgs e)
        {
            OnRedoRequested(this, EventArgs.Empty);
        }

    }
}
