using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHC_Final.ViewModel
{
    public class BookingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static ObservableCollection<AvailableDayViewModel> NoFiltersFirstRow = new ObservableCollection<AvailableDayViewModel>()
        {
            new AvailableDayViewModel()
            {
                Date = "Hoje", AvailableTimes = { }
            },
            new AvailableDayViewModel()
            {
                Date = "Amanhã", AvailableTimes = { new AvailableTimesViewModel() { Time = "20-21h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "29/11",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "19-20h", Teacher = "Marcio", Car = "Palio" },
                    new () { Time = "20-21h", Teacher = "Marcio", Car = "Palio" } }
            },
            new AvailableDayViewModel()
            {
                Date = "30/11",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "13-14h", Teacher = "Irwin", Car = "Palio" },
                    new () { Time = "14-15h", Teacher = "Irwin", Car = "Palio" },
                    new () { Time = "15-16h", Teacher = "Marcio", Car = "Palio" } }
            },
            new AvailableDayViewModel()
            {
                Date = "01/12",
                AvailableTimes = { new () { Time = "08-09h", Teacher = "Roberto", Car = "Palio" },
                    new () { Time = "09-10h", Teacher = "Roberto", Car = "Palio" },
                    new () { Time = "14-15h", Teacher = "Marcio", Car = "Palio" },
                    new () { Time = "20-21h", Teacher = "Marcio", Car = "Palio" } }
            }
        };
        public static ObservableCollection<AvailableDayViewModel> NoFiltersSecondRow = new ObservableCollection<AvailableDayViewModel>()
        {
            new AvailableDayViewModel()
            {
                Date = "02/12",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "19-20h", Teacher = "Marcio", Car = "Uno" },
                    new () { Time = "20-21h", Teacher = "Marcio", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "03/12",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "13-14h", Teacher = "Irwin", Car = "Palio" },
                    new () { Time = "14-15h", Teacher = "Irwin", Car = "Palio" },
                    new () { Time = "15-16h", Teacher = "Marcio", Car = "Palio" } }
            },
            new AvailableDayViewModel()
            {
                Date = "06/12",
                AvailableTimes = { new () { Time = "08-09h", Teacher = "Roberto", Car = "Palio" },
                    new () { Time = "09-10h", Teacher = "Roberto", Car = "Palio" },
                    new () { Time = "14-15h", Teacher = "Marcio", Car = "Palio" },
                    new () { Time = "20-21h", Teacher = "Marcio", Car = "Palio" } }
            },
            new AvailableDayViewModel()
            {
                Date = "07/12",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "15-16h", Teacher = "Marcio", Car = "Palio" } }
            },
            new AvailableDayViewModel()
            {
                Date = "08/12",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "19-20h", Teacher = "Marcio", Car = "Palio" },
                    new () { Time = "20-21h", Teacher = "Marcio", Car = "Palio" } }
            }
        };

        public static ObservableCollection<AvailableDayViewModel> TeacherFilterFirstRow = new ObservableCollection<AvailableDayViewModel>()
        {
            new AvailableDayViewModel()
            {
                Date = "Hoje", AvailableTimes = { }
            },
            new AvailableDayViewModel()
            {
                Date = "Amanhã", AvailableTimes = { new AvailableTimesViewModel() { Time = "20-21h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "29/11",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "30/11",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "01/12",
                AvailableTimes = { new () { Time = "08-09h", Teacher = "Roberto", Car = "Palio" },
                    new () { Time = "09-10h", Teacher = "Roberto", Car = "Palio" } }
            }
        };
        public static ObservableCollection<AvailableDayViewModel> TeacherFilterSecondRow = new ObservableCollection<AvailableDayViewModel>()
        {
            new AvailableDayViewModel()
            {
                Date = "02/12",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "03/12",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "06/12",
                AvailableTimes = { new () { Time = "08-09h", Teacher = "Roberto", Car = "Palio" },
                    new () { Time = "09-10h", Teacher = "Roberto", Car = "Palio" } }
            },
            new AvailableDayViewModel()
            {
                Date = "07/12",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "08/12",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" } }
            }
        };

        public static ObservableCollection<AvailableDayViewModel> CarFilterFirstRow = new ObservableCollection<AvailableDayViewModel>()
        {
            new AvailableDayViewModel()
            {
                Date = "Hoje", AvailableTimes = { }
            },
            new AvailableDayViewModel()
            {
                Date = "Amanhã", AvailableTimes = { new AvailableTimesViewModel() { Time = "20-21h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "29/11",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "30/11",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "01/12",
                AvailableTimes = { }
            }
        };
        public static ObservableCollection<AvailableDayViewModel> CarFilterSecondRow = new ObservableCollection<AvailableDayViewModel>()
        {
            new AvailableDayViewModel()
            {
                Date = "02/12",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "19-20h", Teacher = "Marcio", Car = "Uno" },
                    new () { Time = "20-21h", Teacher = "Marcio", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "03/12",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "06/12",
                AvailableTimes = { }
            },
            new AvailableDayViewModel()
            {
                Date = "07/12",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "08/12",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" } }
            }
        };

        public static ObservableCollection<AvailableDayViewModel> BothFilterFirstRow = new ObservableCollection<AvailableDayViewModel>()
        {
            new AvailableDayViewModel()
            {
                Date = "Hoje", AvailableTimes = { }
            },
            new AvailableDayViewModel()
            {
                Date = "Amanhã", AvailableTimes = { new AvailableTimesViewModel() { Time = "20-21h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "29/11",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "30/11",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "01/12",
                AvailableTimes = { }
            }
        };
        public static ObservableCollection<AvailableDayViewModel> BothFilterSecondRow = new ObservableCollection<AvailableDayViewModel>()
        {
            new AvailableDayViewModel()
            {
                Date = "02/12",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "03/12",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "06/12",
                AvailableTimes = { }
            },
            new AvailableDayViewModel()
            {
                Date = "07/12",
                AvailableTimes = { new () { Time = "09-10h", Teacher = "Roberto", Car = "Uno" },
                    new () { Time = "10-11h", Teacher = "Roberto", Car = "Uno" } }
            },
            new AvailableDayViewModel()
            {
                Date = "08/12",
                AvailableTimes = { new () { Time = "15-16h", Teacher = "Roberto", Car = "Uno" } }
            }
        };

        public ObservableCollection<AvailableDayViewModel> Next5Days { get; set; } = NoFiltersFirstRow;
        public ObservableCollection<AvailableDayViewModel> NextNext5Days { get; set; } = NoFiltersSecondRow;
        public ObservableCollection<string> Teachers { get; } = new ObservableCollection<string>() { "Roberto", "Marcio", "Irwin" };
        public ObservableCollection<string> Cars { get; } = new ObservableCollection<string>() { "Palio", "Uno" };

        public bool CarFiltered = false;
        public bool TeacherFiltered = false;
    }
}
