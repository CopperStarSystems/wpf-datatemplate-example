// MainWindow.xaml.cs
// Created: 2017-05-11

using System.Windows;
using DataTemplates.Model;
using DataTemplates.ViewModel;

namespace DataTemplates
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void AddApple_OnClick(object sender, RoutedEventArgs e)
        {
            var viewModel = (MainViewModel) DataContext;
            viewModel.Fruits.Add(new Apple());
        }

        void AddOrange_OnClick(object sender, RoutedEventArgs e)
        {
            var viewModel = (MainViewModel) DataContext;
            viewModel.Fruits.Add(new Orange());
        }
    }
}