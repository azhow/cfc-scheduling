using IHC_Final.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IHC_Final.View
{
    /// <summary>
    /// Interaction logic for CategorySelectionPage.xaml
    /// </summary>
    public partial class CategorySelectionPage : Page
    {
        public CategorySelectionViewModel ViewModel { get; private set; }

        public CategorySelectionPage()
        {
            ViewModel = new CategorySelectionViewModel();
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
