using Project_Daisy.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MenuPage = Project_Daisy.Views.MenuPage;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Project_Daisy
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; private set; }
        private static Root RootPage;

        public static bool MenuIsPresented
        {
            get => RootPage.IsPresented;
            set => RootPage.IsPresented = value;
        }

        public App()
        {
            InitializeComponent();
            var menuPage = new MenuPage();
            NavigationPage = new NavigationPage(new Home());
            RootPage = new Root
            {
                Master = menuPage,
                Detail = NavigationPage
            };
            MainPage = RootPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}