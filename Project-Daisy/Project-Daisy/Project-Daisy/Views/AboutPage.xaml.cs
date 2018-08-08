using Newtonsoft.Json;
using Project_Daisy.Model;
using RestSharp;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Daisy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var client = new RestClient("http://cinderellacoreapi.azurewebsites.net");
            var request = new RestRequest("api/showcase/getshowcaseditems/1", Method.GET);
            request.AddHeader("Authorization", "p6UUHC2+wuS-YAaS");
            request.AddHeader("Accept", "appliction/json");
            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                var items = JsonConvert.DeserializeObject<List<ShowcasedItem>>(response.Content);
                itemView.ItemsSource = items;
            }
        }
    }
}