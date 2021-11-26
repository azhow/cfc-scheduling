using System.Windows;

namespace IHC_Final.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _navigationFrame.Navigate(Common.NavigationStack.Instance.NextPage);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Common.NavigationStack.Instance.CurrentPage is not OperationResultPage)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Você tem certeza?", "Abandonar operações até agora", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    _navigationFrame.Navigate(Common.NavigationStack.Instance.StartPage);
                }
            }
            else
            {
                _navigationFrame.Navigate(Common.NavigationStack.Instance.StartPage);
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Você tem certeza?", "Confirmar fechamento do programa", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
