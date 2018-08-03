using Project_Daisy.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Daisy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            BindingContext = new MenuPageViewModel();
            Title = "Menu";
            InitializeComponent();
        }
    }
}