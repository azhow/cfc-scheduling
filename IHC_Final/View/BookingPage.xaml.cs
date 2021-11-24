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
        public static CategorySelectionViewModel ViewModel { get; } = new CategorySelectionViewModel();

        public BookingPage()
        {
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

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewModel.OptionSelected((sender as ListView).SelectedIndex);
        }
    }
}
