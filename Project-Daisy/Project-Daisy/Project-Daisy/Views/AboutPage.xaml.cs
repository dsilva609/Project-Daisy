using Newtonsoft.Json;
using Project_Daisy.Model;
using RestSharp;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Daisy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        private bool _isRefreshing = false;

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(() =>
                {
                    itemView.IsRefreshing = true;

                    GetItems();

                    itemView.IsRefreshing = false;
                });
            }
        }

        public AboutPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            itemView.IsPullToRefreshEnabled = true;
            itemView.RefreshCommand = RefreshCommand;
            var image = new Image
            {
                Source = new UriImageSource()
            };
            itemView.ItemsSource = GetItems();
        }

        private List<ShowcasedItem> GetItems()
        {
            var client = new RestClient("http://cinderellacore.azurewebsites.net");
            var request = new RestRequest("api/showcase/getshowcaseditems/1", Method.GET);
            request.AddHeader("Authorization", "p6UUHC2+wuS-YAaS");
            request.AddHeader("Accept", "appliction/json");
            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                var items = JsonConvert.DeserializeObject<List<ShowcasedItem>>(response.Content);

                return items;
            }

            return new List<ShowcasedItem>();
        }
    }
}