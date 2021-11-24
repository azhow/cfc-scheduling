using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHC_Final.ViewModel
{
    public class OperationSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsForwardButtonEnabled { get; private set; }
        public bool IsBackButtonEnabled { get => false; }
        public static ObservableCollection<string> AvailableOperations { get; } = new ObservableCollection<string>()
        {
            "Marcar aulas",
            "Consultar aulas marcadas"
        };

        public void OptionSelected(int selectedIndex)
        {
            IsForwardButtonEnabled = selectedIndex != -1;
        }
    }
}
