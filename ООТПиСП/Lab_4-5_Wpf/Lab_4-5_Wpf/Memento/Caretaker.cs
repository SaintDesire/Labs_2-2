using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5_Wpf.Memento
{
    public class Caretaker
    {
        public Stack<ProductMemento> UndoHistory { get; private set; }
        public Stack<ProductMemento> RedoHistory { get; private set; }
        public Caretaker()
        {
            UndoHistory = new Stack<ProductMemento>();
            RedoHistory = new Stack<ProductMemento>();
        }
    }
}
