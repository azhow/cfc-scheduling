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
    }
}
