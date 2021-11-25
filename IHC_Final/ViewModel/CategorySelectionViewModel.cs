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
    public class CategorySelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsForwardButtonEnabled { get; private set; }
        public bool IsBackButtonEnabled { get => true; }
        public static ObservableCollection<string> AvailableOptions { get; } = new ObservableCollection<string>()
        {
            "A - Motos",
            "ACC - Ciclomotor",
            "B - Carros",
            "C - Caminhões leves",
            "D - Transporte de pessoas",
            "E - Caminhões pesados"
        };
        private int _selectedIndex = -1;
        public int SelectedIndex 
        { 
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (value > -1)
                {
                    _selectedIndex = value;
                    IsForwardButtonEnabled = true;
                }
            }
        }

        public void OptionSelected(int selectedIndex)
        {
            IsForwardButtonEnabled = SelectedIndex != -1;
        }
    }
}
