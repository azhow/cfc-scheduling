using IHC_Final.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;

namespace IHC_Final.View
{
    /// <summary>
    /// Interaction logic for BookingPage.xaml
    /// </summary>
    public partial class ExtractPage : Page
    {
        public bool FromSchedule { get; set; }

        public ObservableCollection<AvailableTimesViewModel> ScheduledTimes { get; set; } = new()
        {
            new() { Time = "30/11 - 09-10h |", Teacher = "Roberto |", Car = "Uno" },
            new() { Time = "30/11 - 10-11h |", Teacher = "Roberto |", Car = "Uno" },
            new() { Time = "07/12 - 09-10h |", Teacher = "Roberto |", Car = "Uno" }
        };

        public ExtractPage(bool fromSchedule)
        {
            DataContext = this;
            FromSchedule = fromSchedule;
            InitializeComponent();
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Common.NavigationStack.Instance.NextPage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Common.NavigationStack.Instance.PreviousPage);
        }
    }
}
