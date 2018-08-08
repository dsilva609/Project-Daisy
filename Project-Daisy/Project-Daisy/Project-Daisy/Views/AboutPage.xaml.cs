using Project_Daisy.Models;
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
            itemView.ItemsSource = new List<Item>
            {
                new Item
                {
                    Description = "test 1",
                },
                new Item{Description = "test 2"}
            };
        }
    }
}