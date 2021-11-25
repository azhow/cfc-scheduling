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

        public bool IsForwardButtonEnabled { get => _operationIndex != -1; }
        public bool IsBackButtonEnabled { get => false; }
        public static ObservableCollection<string> AvailableOperations { get; } = new ObservableCollection<string>()
        {
            "Marcar aulas",
            "Consultar aulas marcadas"
        };
        private int _operationIndex = -1;
        public int OperationIndex
        {
            get
            {
                return _operationIndex;
            }
            set
            {
                _operationIndex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsForwardButtonEnabled)));
            }
        }
    }
}
