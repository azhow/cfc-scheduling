using IHC_Final.ViewModel;
using System;
using System.Collections.Generic;
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
    public partial class BookingPage : Page
    {
        public BookingViewModel ViewModel { get; }

        public BookingPage()
        {
            ViewModel = new BookingViewModel();
            DataContext = ViewModel;
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

        private void CarFilter_Set(object sender, SelectionChangedEventArgs e)
        {
            if (!ViewModel.TeacherFiltered)
            {
                ViewModel.Next5Days = BookingViewModel.CarFilterFirstRow;
                ViewModel.NextNext5Days = BookingViewModel.CarFilterSecondRow;
            }
            else
            {
                ViewModel.Next5Days = BookingViewModel.BothFilterFirstRow;
                ViewModel.NextNext5Days = BookingViewModel.BothFilterSecondRow;
            }
            ViewModel.CarFiltered = true;
        }

        private void TeacherFilter_Set(object sender, SelectionChangedEventArgs e)
        {
            if (!ViewModel.CarFiltered)
            {
                ViewModel.Next5Days = BookingViewModel.TeacherFilterFirstRow;
                ViewModel.NextNext5Days = BookingViewModel.TeacherFilterSecondRow;
            }
            else
            {
                ViewModel.Next5Days = BookingViewModel.BothFilterFirstRow;
                ViewModel.NextNext5Days = BookingViewModel.BothFilterSecondRow;
            }
            ViewModel.TeacherFiltered = true;
        }

        private void CleanFilters_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CarFiltered = false;
            ViewModel.TeacherFiltered = false;
            TeacherFilter.SelectedIndex = -1;
            CarFilter.SelectedIndex = -1;
            ViewModel.Next5Days = BookingViewModel.NoFiltersFirstRow;
            ViewModel.NextNext5Days = BookingViewModel.NoFiltersSecondRow;
        }
    }
}
