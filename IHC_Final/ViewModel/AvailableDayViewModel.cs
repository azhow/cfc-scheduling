using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHC_Final.ViewModel
{
    public class AvailableDayViewModel
    {
        public string Date { get; set; }
        public ObservableCollection<AvailableTimesViewModel> AvailableTimes { get; set; } = new (){ };
    }
}
