using Xamarin.Forms;

namespace Project_Daisy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnAlbums.Clicked += BtnAlbums_Clicked;
            btnBooks.Clicked += BtnBooks_Clicked;
            btnGames.Clicked += BtnGames_Clicked;
            btnMovies.Clicked += BtnMovies_Clicked;
        }

        private void BtnAlbums_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Woo Albums", "Some Albums", "Gotcha");
        }

        private void BtnBooks_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Bookz", "Read Moar", "Turn Page");
        }

        private void BtnGames_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Gaymez", "Play 'em", "Start");
        }

        private void BtnMovies_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Mooves", "Now Showing", "Sit Down");
        }
    }
}