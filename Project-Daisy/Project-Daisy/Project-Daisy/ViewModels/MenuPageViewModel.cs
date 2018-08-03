using Project_Daisy.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Project_Daisy.ViewModels
{
    public class MenuPageViewModel
    {
        public ICommand GoHomeCommand { get; set; }
        public ICommand GoSecondCommand { get; set; }

        public MenuPageViewModel()
        {
            GoHomeCommand = new Command(GoHome);
            GoSecondCommand = new Command(GoSecond);
        }

        public void GoHome(object obj)
        {
            App.NavigationPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

        public void GoSecond(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new AboutPage());
            App.MenuIsPresented = false;
        }
    }
}