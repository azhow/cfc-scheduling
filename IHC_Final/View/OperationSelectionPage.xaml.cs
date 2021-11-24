﻿using IHC_Final.ViewModel;
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
    /// Interaction logic for OperationSelectionPage.xaml
    /// </summary>
    public partial class OperationSelectionPage : Page
    {
        public static OperationSelectionViewModel ViewModel { get; } = new OperationSelectionViewModel();

        public OperationSelectionPage()
        {
            DataContext = ViewModel;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Common.NavigationStack.Instance.NextPage);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewModel.OptionSelected((sender as ListView).SelectedIndex);
        }
    }
}
