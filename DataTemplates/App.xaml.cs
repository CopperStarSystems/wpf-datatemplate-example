// App.xaml.cs
// Created: 2016-10-10

using System.Windows;
using DataTemplates.ViewModel;

namespace DataTemplates
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Normally this is where you would bootstrap your IoC container
            // to register all types that the app needs to know about.
            // 
            // Once the container is bootstrapped, you would resolve your
            // composition root (basically the entry point) from the container
            // instead of newing stuff up here.
            var viewModel = new MainViewModel();
            var view = new MainWindow {DataContext = viewModel};
            view.Show();
        }
    }
}